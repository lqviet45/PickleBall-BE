using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.UpdateBooking;

internal sealed class UpdateBookingHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<UpdateBookingCommand, Result<BookingDto>>
{
    public async Task<Result<BookingDto>> Handle(
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
            return Result.NotFound();

        // Check if court yard exists
        var courtYard = await unitOfWork.RepositoryCourtYard.GetEntityByConditionAsync(
            x => x.Id == request.CourtYardId,
            false,
            cancellationToken
        );
        if (courtYard == null)
            return Result.NotFound();

        // Check if date exists
        var date = await unitOfWork.RepositoryDate.GetEntityByConditionAsync(
            x => x.Id == booking.DateId,
            false,
            cancellationToken
        );
        if (date == null)
            return Result.NotFound();

        // Update booking
        booking.CourtYardId = request.CourtYardId;
        booking.ModifiedOnUtc = DateTime.UtcNow;
        booking.BookingStatus = BookingStatus.Completed;
        unitOfWork.RepositoryBooking.UpdateAsync(booking);

        // Update date status
        date.DateStatus = DateStatus.Open;
        unitOfWork.RepositoryDate.UpdateAsync(date);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        var bookingDto = mapper.Map<BookingDto>(booking);

        return bookingDto;
    }
}
