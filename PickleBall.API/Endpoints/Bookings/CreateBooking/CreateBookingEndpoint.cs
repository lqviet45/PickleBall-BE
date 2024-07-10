using System.ComponentModel.DataAnnotations;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.CreateBooking;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.CreateBooking;

public record CreateBookingRequest
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

public class CreateBookingEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<CreateBookingRequest>.WithActionResult
{
    [HttpPost]
    [Route("/api/bookings")]
    [SwaggerOperation(
        Summary = "Create a booking",
        Description = "Create a booking",
        OperationId = "Bookings.Create",
        Tags = new[] { "Bookings" }
    )]
    public override async Task<ActionResult> HandleAsync(
        CreateBookingRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var createBookingCommand = new CreateBookingCommand
        {
            CourtGroupId = request.CourtGroupId,
            Email = request.Email,
            NumberOfPlayers = request.NumberOfPlayers,
            BookingDate = request.BookingDate,
            TimeRange = request.TimeRange
        };
        var bookingResult = await mediator.Send(createBookingCommand, cancellationToken);

        return bookingResult.IsSuccess
            ? Created(string.Empty, bookingResult)
            : BadRequest(new { Message = "Booking creation failed", Details = bookingResult });
    }
}
