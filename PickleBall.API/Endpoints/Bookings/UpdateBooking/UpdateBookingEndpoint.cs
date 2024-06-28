using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.UpdateBooking;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.UpdateBooking;

public record UpdateBookingRequest
{
    public Guid BookingId { get; init; }
    public Guid CourtYardId { get; init; }
    public bool IsApproved { get; init; }
}

public class UpdateBookingEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<UpdateBookingRequest>.WithActionResult
{
    [HttpPut]
    [Route("/api/bookings")]
    [SwaggerOperation(
        Summary = "Update a booking",
        Description = "Update a booking",
        OperationId = "Bookings.Update",
        Tags = new[] { "Bookings" }
    )]
    public override async Task<ActionResult> HandleAsync(
        UpdateBookingRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var command = new UpdateBookingCommand
        {
            BookingId = request.BookingId,
            CourtYardId = request.CourtYardId,
            IsApproved = request.IsApproved
        };

        var result = await mediator.Send(command, cancellationToken);

        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
