using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.ConfirmBooking;

public class ConfirmBookingCommand : IRequest<Result<BookingDto>>
{
    public Guid BookingId { get; set; }
    public Guid UserId { get; set; }
    public bool IsConfirmed { get; set; }
}
