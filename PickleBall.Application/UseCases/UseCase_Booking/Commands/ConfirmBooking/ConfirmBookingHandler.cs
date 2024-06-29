using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Application.Notification;
using PickleBall.Domain.DTOs.BookingDtos;
using PickleBall.Domain.DTOs.Notification;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.ConfirmBooking;

internal sealed class ConfirmBookingHandler(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    UserManager<ApplicationUser> userManager
) : IRequestHandler<ConfirmBookingCommand, Result<BookingDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public async Task<Result<BookingDto>> Handle(
        ConfirmBookingCommand request,
        CancellationToken cancellationToken
    )
    {
        // Check if user exists
        var user = await _unitOfWork.RepositoryApplicationUser.GetEntityByConditionAsync(
            x => x.Id == request.UserId,
            false,
            cancellationToken
        );
        if (user is null)
            return Result.NotFound("User not found");

        // Check if court group exists
        var booking = await _unitOfWork.RepositoryBooking.GetEntityByConditionAsync(
            x => x.Id == request.BookingId,
            false,
            cancellationToken
        );
        if (booking is null)
            return Result.NotFound("Booking not found");

        // Check if booking is already completed
        if (booking.BookingStatus == BookingStatus.Completed)
            return Result.Error("Booking is already completed");

        // Check if booking is already cancelled
        if (booking.BookingStatus == BookingStatus.Cancelled)
            return Result.Error("Booking is already cancelled");

        // Check if booking is already completed
        if (request.IsConfirmed)
            booking.BookingStatus = BookingStatus.Completed;
        else
            booking.BookingStatus = BookingStatus.Cancelled;

        _unitOfWork.RepositoryBooking.UpdateAsync(booking);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        if (request.IsConfirmed)
            await SendNotification(
                _userManager,
                booking,
                "Booking confirmed successfully",
                "Your booking has been confirmed successfully"
            );
        else
            await SendNotification(
                _userManager,
                booking,
                "Booking cancelled successfully",
                "Your booking has been cancelled successfully"
            );

        var bookingDto = _mapper.Map<BookingDto>(booking);

        return Result.Success(bookingDto);
    }

    private static async Task SendNotification(
        UserManager<ApplicationUser> userManager,
        Booking? booking,
        string title,
        string body
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
            PushTitle = title,
            PushBody = body,
        };
        await expoPushClient.PushSendAsync(pushTicketRequest);
    }
}
