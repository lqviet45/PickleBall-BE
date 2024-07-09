using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.BookingDtos;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.CompleteBooking;

public class CompleteBookingCommand : IRequest<Result<BookingDto>>
{
    public Guid BookingId { get; set; }
    public Guid UserId { get; set; }
    public bool IsCompleted { get; set; }
}
