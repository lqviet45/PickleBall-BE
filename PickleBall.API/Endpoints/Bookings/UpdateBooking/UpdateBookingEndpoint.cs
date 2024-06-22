using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.UpdateBooking;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Bookings.UpdateBooking;

public record UpdateBookingRequest
{
    public Guid BookingId { get; init; }
    public Guid CourtYardId { get; init; }
}

public class UpdateBookingEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<UpdateBookingRequest>.WithActionResult
{
    [HttpPut]
    [Route("/api/bookings")]
    public override async Task<ActionResult> HandleAsync(
        UpdateBookingRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var command = new UpdateBookingCommand
        {
            BookingId = request.BookingId,
            CourtYardId = request.CourtYardId
        };

        var result = await mediator.Send(command, cancellationToken);

        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
