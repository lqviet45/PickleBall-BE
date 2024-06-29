using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.BookingDtos;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries.GetBookingById
{
    public class GetBookingByIdQuery : IRequest<Result<BookingDto>>
    {
        public Guid BookingId { get; set; }
        public bool TrackChanges { get; set; } = false;
    }
}
