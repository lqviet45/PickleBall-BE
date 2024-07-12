using System.ComponentModel.DataAnnotations;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PickleBall.Application.UseCases.UseCase_Deposit.Commands.CreateDeposit;
using PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByDeposit;
using PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletBalanceByDeposit;
using Swashbuckle.AspNetCore.Annotations;

namespace PickleBall.API.Endpoints.Deposits.CreateDeposit;

public record CreateDepositRequest
{
    public Guid WalletId { get; set; }
    public Guid UserId { get; set; }

    [Range(10_000, 10_000_000, ErrorMessage = "Amount must be between 10.000 and 10.000.000")]
    public decimal Amount { get; set; }
}

public class CreateDepositEndpoint(IMediator mediator)
    : EndpointBaseAsync.WithRequest<CreateDepositRequest>.WithActionResult
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Route("/api/deposits")]
    [Authorize]
    [SwaggerOperation(
        Summary = "Create a deposit",
        Description = "Create a deposit",
        OperationId = "Deposits.CreateDeposit",
        Tags = new[] { "Deposits" }
    )]
    public override async Task<ActionResult> HandleAsync(
        CreateDepositRequest request,
        CancellationToken cancellationToken = default
    )
    {
        var createDeposit = new CreateDepositCommand
        {
            WalletId = request.WalletId,
            UserId = request.UserId,
            Amount = request.Amount
        };
        var depositResult = await _mediator.Send(createDeposit, cancellationToken);
        if (!depositResult.IsSuccess)
            return BadRequest(depositResult);

        var (depositDto, wallet) = depositResult.Value;

        var createTransaction = new CreateTransactionByDepositCommand
        {
            WalletId = request.WalletId,
            UserId = request.UserId,
            DepositId = depositDto.Id,
            Amount = request.Amount
        };
        var transactionResult = await _mediator.Send(createTransaction, cancellationToken);
        if (!transactionResult.IsSuccess)
            return BadRequest(transactionResult);

        var updateWallet = new UpdateWalletBalanceByDepositCommand
        {
            UserId = request.UserId,
            Wallet = wallet,
            Transaction = transactionResult.Value,
            Amount = request.Amount
        };
        var walletResult = await _mediator.Send(updateWallet, cancellationToken);
        if (!walletResult.IsSuccess)
            return BadRequest(walletResult);

        return Ok(walletResult);
    }
}
