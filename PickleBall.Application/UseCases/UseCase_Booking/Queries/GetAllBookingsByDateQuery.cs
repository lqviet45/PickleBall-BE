using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries;

public class GetAllBookingsByDateQuery : IRequest<Result<IEnumerable<BookingDto>>>
{
    public DateTime Date { get; set; }
    public bool TrackChanges { get; set; } = false;
}
