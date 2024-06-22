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
        var createBookingCommand = new CreateBookingCommand
        {
            CourtGroupId = request.CourtGroupId,
            UserId = request.UserId,
            NumberOfPlayers = request.NumberOfPlayers,
            DateWorking = request.DateWorking
        };
        var BookingResult = await mediator.Send(createBookingCommand, cancellationToken);
        if (!BookingResult.IsSuccess)
            return BadRequest(BookingResult);

        // var createTransactionCommand = new CreateTransactionByBookingCommand
        // {
        //     UserId = BookingResult.Value.UserId,
        //     BookingId = BookingResult.Value.Id,
        //     CourtGroupId = BookingResult.Value.CourtGroupId
        // };
        // var TransactionResult = await mediator.Send(createTransactionCommand, cancellationToken);
        // if (!TransactionResult.IsSuccess)
        //     return BadRequest(TransactionResult);

        return BookingResult.IsSuccess
            ? Created(string.Empty, BookingResult)
            : BadRequest(BookingResult);
    }
}
