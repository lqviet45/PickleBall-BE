using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.BookingDtos;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.ConfirmBooking;

public class ConfirmBookingCommand : IRequest<Result<BookingDto>>
{
    public Guid BookingId { get; set; }
    public Guid CourtYardId { get; set; }
    public bool IsConfirmed { get; set; }
}
