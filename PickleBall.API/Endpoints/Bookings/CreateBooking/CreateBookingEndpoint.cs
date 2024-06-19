using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.CreateBooking;
using PickleBall.Domain.DTOs;

namespace PickleBall.API.Endpoints.Bookings.CreateBooking;

public record CreateBookingRequest
{
    public Guid CourtGroupId { get; set; }
    public Guid UserId { get; set; }
    public int NumberOfPlayers { get; set; }
    public string? DateWorking { get; set; }
}

public class CreateBookingEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<CreateBookingRequest>.WithActionResult
{
    [HttpPost]
    [Route("/api/bookings")]
    public override async Task<ActionResult> HandleAsync(
        CreateBookingRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Result<BookingDto> result = await mediator.Send(
            new CreateBookingCommand
            {
                CourtGroupId = request.CourtGroupId,
                UserId = request.UserId,
                NumberOfPlayers = request.NumberOfPlayers,
                DateWorking = request.DateWorking
            },
            cancellationToken
        );

        if (!result.IsSuccess)
            return BadRequest(result);

        return Created("", result);
    }
}
