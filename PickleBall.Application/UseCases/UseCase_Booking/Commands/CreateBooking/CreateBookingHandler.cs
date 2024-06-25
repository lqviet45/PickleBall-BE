using System.Globalization;
using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.CreateBooking;

internal sealed class CreateBookingHandler(IUnitOfWork unitOfWork, IMapper mapper)
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

        var isDateExist =
            await unitOfWork.RepositoryDate.GetEntityByConditionAsync(
                d => d.DateWorking.Date == parsedDate.Date,
                false,
                cancellationToken
            )
            ?? new()
            {
                DateWorking = parsedDate,
                DateStatus = DateStatus.Open,
                CreatedOnUtc = DateTimeOffset.UtcNow
            };

        return await CreateBookingAsync(request, user, courtGroup, isDateExist);
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
        var courtGroup = await unitOfWork.RepositoryCourtGroup.GetCourtGroupByIdAsync(
            request.CourtGroupId,
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
                Date = date
            };

        unitOfWork.RepositoryBooking.AddAsync(booking);
        var bookingDto = mapper.Map<BookingDto>(booking);

        bookingDto.User = mapper.Map<ApplicationUserDto>(user);
        bookingDto.CourtGroup = mapper.Map<CourtGroupDto>(courtGroup);

        return Result.Success(bookingDto, "Booking created successfully");
    }
}
