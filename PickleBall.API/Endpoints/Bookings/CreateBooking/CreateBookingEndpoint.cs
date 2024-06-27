using System.ComponentModel.DataAnnotations;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.CreateBooking;
using PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByBooking;
using PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletBalance;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.CreateBooking;

public record CreateBookingRequest
{
    public Guid CourtGroupId { get; set; }
    public Guid UserId { get; set; }

    [Range(1, 4)]
    public int NumberOfPlayers { get; set; }
    public string? BookingDate { get; set; }

    [MaxLength(20)]
    public string? TimeRange { get; set; }
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
            UserId = request.UserId,
            NumberOfPlayers = request.NumberOfPlayers,
            BookingDate = request.BookingDate,
            TimeRange = request.TimeRange
        };
        var BookingResult = await mediator.Send(createBookingCommand, cancellationToken);
        if (!BookingResult.IsSuccess)
            return BadRequest(BookingResult);

        var updateWalletBalance = new UpdateWalletBalanceCommand
        {
            UserId = request.UserId,
            CourtGroupId = request.CourtGroupId
        };
        var WalletResult = await mediator.Send(updateWalletBalance, cancellationToken);
        if (!WalletResult.IsSuccess)
            return BadRequest(WalletResult);

        var createTransactionCommand = new CreateTransactionByBookingCommand
        {
            UserId = BookingResult.Value.User.Id,
            BookingId = BookingResult.Value.Id,
            CourtGroupId = BookingResult.Value.CourtGroup.Id
        };
        var TransactionResult = await mediator.Send(createTransactionCommand, cancellationToken);
        if (!TransactionResult.IsSuccess)
            return BadRequest(TransactionResult);

        return BookingResult.IsSuccess
            ? Created(string.Empty, BookingResult)
            : BadRequest(BookingResult);
    }
}
