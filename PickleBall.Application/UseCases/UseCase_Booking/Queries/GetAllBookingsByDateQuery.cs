using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.BookingDtos;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries;

public class GetAllBookingsByDateQuery : IRequest<Result<PagedList<BookingDto>>>
{
    public Guid CourtGroupId { get; set; }
    public DateTime Date { get; set; }
    public bool TrackChanges { get; set; } = false;
    public BookingParameters BookingParameters { get; set; } = new();
}
