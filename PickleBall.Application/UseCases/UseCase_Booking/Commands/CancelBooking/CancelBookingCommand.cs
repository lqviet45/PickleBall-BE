using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.BookingDtos;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.CancelBooking;

public class CancelBookingCommand : IRequest<Result<BookingDto>>
{
    public Guid Id { get; set; }
}
