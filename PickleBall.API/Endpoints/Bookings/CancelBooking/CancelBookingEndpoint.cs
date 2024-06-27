using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.CancelBooking;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.CancelBooking;

public record CancelBookingRequest
{
    [FromRoute]
    public Guid Id { get; set; }
}

public class CancelBookingEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<CancelBookingRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPut]
    [Route("/api/bookings/{Id:guid}/cancel")]
    [SwaggerOperation(
        Summary = "Cancels a booking",
        Description = "Cancels a booking by its Id",
        OperationId = "Bookings.CancelBooking",
        Tags = new[] { "Bookings" }
    )]
    public override async Task<ActionResult> HandleAsync(
        CancelBookingRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<BookingDto> result = await _mediator.Send(
            new CancelBookingCommand { Id = request.Id },
            cancellationToken
        );

        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
