using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.ConfirmBooking;
using PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByBooking;
using PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletBalance;
using PickleBall.Domain.DTOs.BookingDtos;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.ConfirmBooking;

public record ConfirmBookingRequest
{
    [FromRoute]
    public Guid Id { get; set; }

    [FromBody]
    public required ConfirmBookingDto ConfirmBooking { get; init; }
}

public class ConfirmBookingEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<ConfirmBookingRequest>.WithActionResult
{
    private readonly IMediator _mediatr = mediator;

    [HttpPut]
    [Route("/api/bookings/{Id}/confirm")]
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
        if (request.ConfirmBooking.IsConfirmed)
        {
            var updateWalletBalance = new UpdateWalletBalanceCommand
            {
                UserId = request.ConfirmBooking.UserId,
                CourtGroupId = request.ConfirmBooking.CourtGroupId,
            };
            var WalletResult = await mediator.Send(updateWalletBalance, cancellationToken);
            if (!WalletResult.IsSuccess)
                return BadRequest(WalletResult);

            var (userWallet, ownerWallet, courtGroup) = WalletResult.Value;

            var createTransactionCommand = new CreateTransactionByBookingCommand
            {
                UserWallet = userWallet,
                OwnerWallet = ownerWallet,
                CourtGroup = courtGroup,
                BookingId = request.Id,
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
            BookingId = request.Id,
            UserId = request.ConfirmBooking.UserId,
            IsConfirmed = request.ConfirmBooking.IsConfirmed
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
