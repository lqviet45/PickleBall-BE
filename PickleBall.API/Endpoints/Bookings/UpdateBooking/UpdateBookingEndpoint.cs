using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.UpdateBooking;
using PickleBall.Domain.DTOs.BookingDtos;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.UpdateBooking;

public record UpdateBookingRequest
{
    [FromRoute]
    public Guid Id { get; init; }

    [FromBody]
    public required UpdateBookingDto UpdateBooking { get; init; }
}

public class UpdateBookingEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<UpdateBookingRequest>.WithActionResult
{
    [HttpPut]
    [Route("/api/bookings/{Id}/approve")]
    [SwaggerOperation(
        Summary = "Manager approve a booking",
        Description = "Manager approve a booking",
        OperationId = "Bookings.Approve",
        Tags = new[] { "Bookings" }
    )]
    public override async Task<ActionResult> HandleAsync(
        UpdateBookingRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var command = new UpdateBookingCommand
        {
            BookingId = request.Id,
            CourtYardId = request.UpdateBooking.CourtYardId,
            IsApproved = request.UpdateBooking.IsApproved
        };

        var result = await mediator.Send(command, cancellationToken);

        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
