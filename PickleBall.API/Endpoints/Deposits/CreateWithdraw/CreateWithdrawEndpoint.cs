using System.ComponentModel.DataAnnotations;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateWithdraw;
using PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletByWithdraw;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Deposits.CreateWithdraw;

public record CreateWithdrawRequest
{
    public Guid WalletId { get; set; }
    public Guid UserId { get; set; }

    [Range(10_000, 10_000_000, ErrorMessage = "Amount must be between 10.000 and 10.000.000")]
    public decimal Amount { get; set; }
}

public class CreateWithdrawEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<CreateWithdrawRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Route("/api/withdraws")]
    [Authorize]
    [SwaggerOperation(
        Summary = "Create a withdraw",
        Description = "Create a withdraw",
        OperationId = "Withdraws.CreateWithdraw",
        Tags = new[] { "Deposits" }
    )]
    public override async Task<ActionResult> HandleAsync(
        CreateWithdrawRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var createTransaction = new CreateWithdrawCommand
        {
            WalletId = request.WalletId,
            UserId = request.UserId,
            Amount = request.Amount
        };
        var transactionResult = await _mediator.Send(createTransaction, cancellationToken);
        if (!transactionResult.IsSuccess)
            return BadRequest(transactionResult);

        var updateWallet = new UpdateWalletByWithdrawCommand
        {
            UserId = request.UserId,
            Wallet = transactionResult.Value,
            Amount = request.Amount
        };
        var walletResult = await _mediator.Send(updateWallet, cancellationToken);
        if (!walletResult.IsSuccess)
            return BadRequest(walletResult);

        return Ok(walletResult);
    }
}
