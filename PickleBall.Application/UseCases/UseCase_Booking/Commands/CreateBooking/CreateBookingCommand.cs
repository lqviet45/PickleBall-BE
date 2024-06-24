using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.CreateBooking;

public class CreateBookingCommand : IRequest<Result<BookingDto>>
{
    public Guid CourtGroupId { get; set; }
    public Guid UserId { get; set; }
    public int NumberOfPlayers { get; set; }
    public string? BookingDate { get; set; }
    public string? TimeRange { get; set; }
}
