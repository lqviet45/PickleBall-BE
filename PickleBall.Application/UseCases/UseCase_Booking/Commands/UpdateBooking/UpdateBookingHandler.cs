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

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.UpdateBooking;

internal sealed class UpdateBookingHandler(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    UserManager<ApplicationUser> userManager
) : IRequestHandler<UpdateBookingCommand, Result<BookingDto>>
{
    public async Task<Result<BookingDto>> Handle(
        UpdateBookingCommand request,
        CancellationToken cancellationToken
    )
    {
        var validationResult = await IsValidateId(unitOfWork, request, cancellationToken);
        if (!validationResult.IsSuccess)
            return Result<BookingDto>.NotFound(validationResult.SuccessMessage);

        var (booking, date) = validationResult.Value;

        if (booking.BookingStatus == BookingStatus.Completed)
            return Result.Error("Booking is already completed");

        // Update booking
        booking.CourtYardId = request.CourtYardId;
        booking.ModifiedOnUtc = DateTime.UtcNow;
        if (request.IsApproved)
            booking.BookingStatus = BookingStatus.Confirmed;
        else
            booking.BookingStatus = BookingStatus.Cancelled;

        unitOfWork.RepositoryBooking.UpdateAsync(booking);

        // Update date status
        date.DateStatus = DateStatus.Open;
        unitOfWork.RepositoryDate.UpdateAsync(date);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        if (request.IsApproved)
        {
            await SendNotification(
                userManager,
                booking,
                "Booking confirmed successfully",
                "Your booking has been confirmed successfully"
            );
        }
        else
        {
            await SendNotification(
                userManager,
                booking,
                "Booking cancelled successfully",
                "Your booking has been cancelled successfully"
            );
        }

        var bookingDto = mapper.Map<BookingDto>(booking);

        return bookingDto;
    }

    private static async Task<Result<(Booking, Date)>> IsValidateId(
        IUnitOfWork unitOfWork,
        UpdateBookingCommand request,
        CancellationToken cancellationToken
    )
    {
        // Check if booking exists
        var booking = await unitOfWork.RepositoryBooking.GetEntityByConditionAsync(
            x => x.Id == request.BookingId,
            false,
            cancellationToken
        );
        if (booking == null)
            return Result.NotFound("Booking not found");

        // Check if court yard exists
        var courtYard = await unitOfWork.RepositoryCourtYard.GetEntityByConditionAsync(
            x => x.Id == request.CourtYardId,
            false,
            cancellationToken
        );
        if (courtYard == null)
            return Result.NotFound("Court yard not found");

        // Check if date exists
        var date = await unitOfWork.RepositoryDate.GetEntityByConditionAsync(
            x => x.Id == booking.DateId,
            false,
            cancellationToken
        );
        if (date == null)
            return Result.NotFound("Date not found");

        return Result.Success((booking, date));
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
