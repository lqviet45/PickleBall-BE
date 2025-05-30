using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.BookingDtos;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Booking.Queries.GetAllBookings;

public class GetAllBookingsQuery : IRequest<Result<PagedList<BookingDto>>>
{
    public BookingParameters BookingParameters { get; set; } = new();
}
