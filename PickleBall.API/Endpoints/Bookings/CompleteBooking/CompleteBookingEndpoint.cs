using Ardalis.ApiEndpoints;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.CompleteBooking;
using PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByBooking;
using PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletBalance;
using PickleBall.Domain.DTOs.BookingDtos;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Bookings.CompleteBooking;

public record CompleteBookingRequest
{
    [FromRoute]
    public Guid Id { get; set; }

    [FromBody]
    public required CompleteBookingDto CompleteBooking { get; init; }
}

public class CompleteBookingEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<CompleteBookingRequest>.WithActionResult
{
    private readonly IMediator _mediatr = mediator;

    [HttpPut]
    [Route("/api/bookings/{Id}/complete")]
    [Authorize]
    [SwaggerOperation(
        Summary = "Complete booking",
        Description = "Complete booking",
        OperationId = "Bookings.CompleteBooking",
        Tags = new[] { "Bookings" }
    )]
    public override async Task<ActionResult> HandleAsync(
        CompleteBookingRequest request,
        CancellationToken cancellationToken = default
    )
    {
        if (request.CompleteBooking.IsCompleted)
        {
            var updateWalletBalance = new UpdateWalletBalanceCommand
            {
                UserId = request.CompleteBooking.UserId,
                CourtGroupId = request.CompleteBooking.CourtGroupId,
                BookingId = request.Id
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

        var CompleteBookingCommand = new CompleteBookingCommand
        {
            BookingId = request.Id,
            UserId = request.CompleteBooking.UserId,
            IsCompleted = request.CompleteBooking.IsCompleted
        };
        Result<BookingDto> bookingResult = await _mediatr.Send(
            CompleteBookingCommand,
            cancellationToken
        );
        if (!bookingResult.IsSuccess)
            return BadRequest(bookingResult);

        return Ok(bookingResult);
    }
}
