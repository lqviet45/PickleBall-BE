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
        var user = await EnsureUserExistsAsync(request.UserId, cancellationToken);
        if (!user.IsSuccess)
            return Result<BookingDto>.NotFound("User not found");

        var courtGroup = await EnsureCourtGroupExistsAsync(request.CourtGroupId, cancellationToken);
        if (!courtGroup.IsSuccess)
            return Result<BookingDto>.NotFound("Court group not found");

        if (!ValidateDate(request.DateWorking, out DateTime parsedDate).IsSuccess)
            return Result<BookingDto>.Invalid();

        var date = await CreateDateAsync(parsedDate, cancellationToken);

        return await CreateBookingAsync(request, date, cancellationToken);
    }

    private async Task<Result<ApplicationUser>> EnsureUserExistsAsync(
        Guid userId,
        CancellationToken cancellationToken
    )
    {
        ApplicationUser? user = await unitOfWork.RepositoryApplicationUser.GetUserByIdAsync(
            userId,
            false,
            cancellationToken
        );

        return user is null
            ? Result<ApplicationUser>.NotFound("User not found")
            : Result<ApplicationUser>.Success(user);
    }

    private async Task<Result<CourtGroup>> EnsureCourtGroupExistsAsync(
        Guid courtGroupId,
        CancellationToken cancellationToken
    )
    {
        CourtGroup? courtGroup = await unitOfWork.RepositoryCourtGroup.GetCourtGroupByIdAsync(
            courtGroupId,
            false,
            cancellationToken
        );

        return courtGroup is null
            ? Result<CourtGroup>.NotFound("Court group not found")
            : Result<CourtGroup>.Success(courtGroup);
    }

    private static Result<bool> ValidateDate(string inputDate, out DateTime parsedDate)
    {
        string[] formats = ["dd-MM-yyyy", "yyyy-MM-dd"];
        var a = DateTime.TryParseExact(
            inputDate,
            formats,
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out parsedDate
        );

        return Result.Success(a) ? Result.Success(true) : Result.Invalid();
    }

    private async Task<Date> CreateDateAsync(
        DateTime dateWorking,
        CancellationToken cancellationToken
    )
    {
        Date date =
            new()
            {
                DateWorking = dateWorking,
                DateStatus = DateStatus.Pending,
                CreatedOnUtc = DateTimeOffset.UtcNow
            };

        unitOfWork.RepositoryDate.AddAsync(date);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success(date);
    }

    private async Task<Result<BookingDto>> CreateBookingAsync(
        CreateBookingCommand request,
        Date date,
        CancellationToken cancellationToken
    )
    {
        var booking = mapper.Map<Booking>(request);

        booking.BookingStatus = BookingStatus.Pending;
        booking.CreatedOnUtc = DateTimeOffset.UtcNow;
        booking.Date = date;

        unitOfWork.RepositoryBooking.AddAsync(booking);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var bookingDto = mapper.Map<BookingDto>(booking);

        return Result.Success(bookingDto, "Booking created successfully");
    }
}
