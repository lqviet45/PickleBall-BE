using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.UpdateBooking;

public class UpdateBookingCommand : IRequest<Result<BookingDto>>
{
    public Guid BookingId { get; set; }
    public Guid CourtYardId { get; set; }
    public bool IsApproved { get; set; }
}
