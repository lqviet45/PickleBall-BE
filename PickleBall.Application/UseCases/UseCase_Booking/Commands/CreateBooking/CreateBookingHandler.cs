using System.Globalization;
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

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.CreateBooking;

internal sealed class CreateBookingHandler(IUnitOfWork unitOfWork, IMapper mapper, UserManager<ApplicationUser> userManager)
    : IRequestHandler<CreateBookingCommand, Result<BookingDto>>
{
    public async Task<Result<BookingDto>> Handle(
        CreateBookingCommand request,
        CancellationToken cancellationToken
    )
    {
        var validationResult = await IsValidateId(unitOfWork, request, cancellationToken);
        if (!validationResult.IsSuccess)
            return Result<BookingDto>.NotFound("Cannot found user or court group");

        var (user, courtGroup) = validationResult.Value;

        if (!ValidateDate(request.BookingDate, out DateTime parsedDate).IsSuccess)
            return Result.Error("Invalid date format");

        var dateResult = await GetOrCreateDateAsync(parsedDate, cancellationToken);
        if (!dateResult.IsSuccess)
            return Result.Error("Failed to get or create date");

        return await CreateBookingAsync(request, user, courtGroup, dateResult);
    }

    private static async Task<Result<(ApplicationUser user, CourtGroup courtGroup)>> IsValidateId(
        IUnitOfWork unitOfWork,
        CreateBookingCommand request,
        CancellationToken cancellationToken
    )
    {
        // Check if user exists
        var user = await unitOfWork.RepositoryApplicationUser.GetUserByIdAsync(
            request.UserId,
            false,
            cancellationToken
        );
        if (user is null)
            return Result.NotFound("User not found");

        // Check if court group exists
        var courtGroup = await unitOfWork.RepositoryCourtGroup.GetCourtGroupByConditionAsync(
            c => c.Id == request.CourtGroupId,
            false,
            cancellationToken
        );
        if (courtGroup is null)
            return Result.NotFound("Court group not found");

        return Result.Success((user, courtGroup));
    }

    private static Result<bool> ValidateDate(string? inputDate, out DateTime parsedDate)
    {
        parsedDate = default;

        if (string.IsNullOrWhiteSpace(inputDate))
            return Result.Invalid();

        string[] formats = ["dd-MM-yyyy", "yyyy-MM-dd"];
        var IsValidDate = DateTime.TryParseExact(
            inputDate,
            formats,
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out parsedDate
        );

        if (parsedDate < DateTime.UtcNow.Date)
            return Result.Error("Date cannot be in the past");

        return Result.Success(IsValidDate)
            ? Result.Success(true)
            : Result.Error("Invalid date format");
    }

    private async Task<Result<Date>> GetOrCreateDateAsync(
        DateTime parsedDate,
        CancellationToken cancellationToken
    )
    {
        var existingDate = await unitOfWork.RepositoryDate.GetEntityByConditionAsync(
            d => d.DateWorking.Date == parsedDate.Date,
            false,
            cancellationToken
        );

        if (existingDate != null)
            return Result.Success(existingDate);

        var newDate = new Date
        {
            DateWorking = parsedDate,
            DateStatus = DateStatus.Open,
            CreatedOnUtc = DateTimeOffset.UtcNow
        };

        unitOfWork.RepositoryDate.AddAsync(newDate);

        return Result.Success(newDate);
    }

    private async Task<Result<BookingDto>> CreateBookingAsync(
        CreateBookingCommand request,
        ApplicationUser user,
        CourtGroup courtGroup,
        Date date
    )
    {
        Booking booking =
            new()
            {
                CourtGroupId = request.CourtGroupId,
                UserId = request.UserId,
                NumberOfPlayers = request.NumberOfPlayers,
                TimeRange = request.TimeRange,
                BookingStatus = BookingStatus.Pending,
                CreatedOnUtc = DateTimeOffset.UtcNow,
                DateId = date.Id
            };

        unitOfWork.RepositoryBooking.AddAsync(booking);
        var bookingDto = mapper.Map<BookingDto>(booking);
        var userToken = await userManager.Users
            .Where(u => u.DeviceToken != null && u.Id == request.UserId)
            .Select(u => u.DeviceToken)
            .Distinct()
            .ToListAsync();
        
        var expoPushClient = new PushExpoApiClient();
        var pushTicketRequest = new PushTicketRequest
        {
            PushTo = userToken!,
            PushTitle = "Booking Success",
            PushBody = "Please wait for the confirmation",
        };
        await expoPushClient.PushSendAsync(pushTicketRequest);
        
        bookingDto.User = mapper.Map<ApplicationUserDto>(user);
        bookingDto.CourtGroup = mapper.Map<CourtGroupDto>(courtGroup);

        return Result.Success(bookingDto, "Booking created successfully");
    }
}
