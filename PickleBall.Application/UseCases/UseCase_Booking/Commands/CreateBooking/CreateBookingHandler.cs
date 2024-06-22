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

        if (!ValidateDate(request.DateWorking, out DateTime parsedDate).IsSuccess)
            return Result.Invalid();

        return await CreateBookingAsync(request, parsedDate, cancellationToken);
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
            return Result.Invalid();

        return Result.Success(IsValidDate) ? Result.Success(true) : Result.Invalid();
    }

    private async Task<Result<BookingDto>> CreateBookingAsync(
        CreateBookingCommand request,
        DateTime parsedDate,
        CancellationToken cancellationToken
    )
    {
        Booking booking =
            new()
            {
                CourtGroupId = request.CourtGroupId,
                UserId = request.UserId,
                NumberOfPlayers = request.NumberOfPlayers,
                BookingStatus = BookingStatus.Pending,
                CreatedOnUtc = DateTimeOffset.UtcNow,
                Date = new()
                {
                    DateWorking = parsedDate,
                    DateStatus = DateStatus.Pending,
                    CreatedOnUtc = DateTimeOffset.UtcNow
                }
            };

        unitOfWork.RepositoryBooking.AddAsync(booking);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var bookingDto = mapper.Map<BookingDto>(booking);

        return Result.Success(bookingDto, "Booking created successfully");
    }
}
