using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingByUserId
{
    public class GetBookingByUserIdQuery : IRequest<Result<IEnumerable<BookingDto>>>
    {
        public Guid UserId { get; set; }
        public bool TrackChanges { get; set; } = false;
        public BookingParameters BookingParameters { get; set; } = new();
    }
}
