using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Application.Notification;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.Notification;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.CancelBooking;

public class CancelBookingHandler(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    UserManager<ApplicationUser> userManager
) : IRequestHandler<CancelBookingCommand, Result<BookingDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public async Task<Result<BookingDto>> Handle(
        CancelBookingCommand request,
        CancellationToken cancellationToken
    )
    {
        var booking = await _unitOfWork.RepositoryBooking.GetBookingByIdAsync(
            request.Id,
            false,
            cancellationToken
        );
        if (booking is null)
            return Result.NotFound("Booking not found");

        if (booking.BookingStatus is BookingStatus.Pending or BookingStatus.Confirmed)
            booking.BookingStatus = BookingStatus.Cancelled;

        _unitOfWork.RepositoryBooking.UpdateAsync(booking);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        await SendNotification(userManager, booking);

        var bookingDto = _mapper.Map<BookingDto>(booking);

        return Result<BookingDto>.Success(bookingDto);
    }

    private static async Task SendNotification(
        UserManager<ApplicationUser> userManager,
        Booking? booking
    )
    {
        var userToken = await userManager
            .Users.Where(u => u.DeviceToken != null && u.Id == booking.UserId)
            .Select(u => u.DeviceToken)
            .Distinct()
            .ToListAsync();

        var expoPushClient = new PushExpoApiClient();
        var pushTicketRequest = new PushTicketRequest
        {
            PushTo = userToken!,
            PushTitle = "Booking Cancel Successfully",
            PushBody = "Your booking has been cancelled successfully",
        };
        await expoPushClient.PushSendAsync(pushTicketRequest);
    }
}
