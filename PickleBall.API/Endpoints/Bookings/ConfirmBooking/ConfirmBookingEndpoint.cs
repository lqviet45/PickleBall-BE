using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.ConfirmBooking;
using PickleBall.Domain.DTOs.BookingDtos;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.ConfirmBooking;

public record ConfirmBookingRequest
{
    [FromRoute]
    public Guid Id { get; init; }

    [FromBody]
    public required ConfirmBookingDto ConfirmBooking { get; init; }
}

public class ConfirmBookingEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<ConfirmBookingRequest>.WithActionResult
{
    [HttpPut]
    [Route("/api/bookings/{Id}/confirm")]
    [Authorize(Roles = "Owner, Manager")]
    [SwaggerOperation(
        Summary = "Manager confirm a booking",
        Description = "Manager confirm a booking",
        OperationId = "Bookings.confirm",
        Tags = new[] { "Bookings" }
    )]
    public override async Task<ActionResult> HandleAsync(
        ConfirmBookingRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var command = new ConfirmBookingCommand
        {
            BookingId = request.Id,
            CourtYardId = request.ConfirmBooking.CourtYardId,
            IsConfirmed = request.ConfirmBooking.IsConfirmed,
            SlotIds = request.ConfirmBooking.SlotIds
        };

        var result = await mediator.Send(command, cancellationToken);

        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
