using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.ConfirmBooking;
using PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByBooking;
using PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletBalance;
using PickleBall.Domain.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.ConfirmBooking;

public record ConfirmBookingRequest
{
    public Guid BookingId { get; set; }
    public Guid UserId { get; set; }
    public Guid CourtGroupId { get; set; }
    public bool IsConfirmed { get; set; }
}

public class ConfirmBookingEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<ConfirmBookingRequest>.WithActionResult
{
    private readonly IMediator _mediatr = mediator;

    [HttpPut]
    [Route("/api/bookings/confirm")]
    [SwaggerOperation(
        Summary = "Confirm booking",
        Description = "Confirm booking",
        OperationId = "Bookings.ConfirmBooking",
        Tags = new[] { "Bookings" }
    )]
    public override async Task<ActionResult> HandleAsync(
        ConfirmBookingRequest request,
        CancellationToken cancellationToken = default
    )
    {
        if (request.IsConfirmed)
        {
            var updateWalletBalance = new UpdateWalletBalanceCommand
            {
                UserId = request.UserId,
                CourtGroupId = request.CourtGroupId,
            };
            var WalletResult = await mediator.Send(updateWalletBalance, cancellationToken);
            if (!WalletResult.IsSuccess)
                return BadRequest(WalletResult);

            var createTransactionCommand = new CreateTransactionByBookingCommand
            {
                UserId = request.UserId,
                BookingId = request.BookingId,
                CourtGroupId = request.CourtGroupId,
            };
            var TransactionResult = await mediator.Send(
                createTransactionCommand,
                cancellationToken
            );
            if (!TransactionResult.IsSuccess)
                return BadRequest(TransactionResult);
        }

        var confirmBookingCommand = new ConfirmBookingCommand
        {
            BookingId = request.BookingId,
            UserId = request.UserId,
            IsConfirmed = request.IsConfirmed
        };
        Result<BookingDto> bookingResult = await _mediatr.Send(
            confirmBookingCommand,
            cancellationToken
        );
        if (!bookingResult.IsSuccess)
            return BadRequest(bookingResult);

        return Ok(bookingResult);
    }
}
