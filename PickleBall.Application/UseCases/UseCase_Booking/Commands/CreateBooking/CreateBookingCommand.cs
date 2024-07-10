using System.ComponentModel.DataAnnotations;
using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.BookingDtos;

namespace PickleBall.Application.UseCases.UseCase_Booking.Commands.CreateBooking;

public class CreateBookingCommand : IRequest<Result<BookingDto>>
{
    [Required]
    public Guid CourtGroupId { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Range(1, 4)]
    public int NumberOfPlayers { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public required string BookingDate { get; set; }

    [Required]
    [MaxLength(20)]
    public required string TimeRange { get; set; }
}
