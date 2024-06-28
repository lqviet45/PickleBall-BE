using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByDeposit;

public class CreateTransactionByDepositCommand : IRequest<Result<TransactionDto>>
{
    public Guid WalletId { get; set; }
    public Guid UserId { get; set; }
    public Guid DepositId { get; set; }
    public decimal Amount { get; set; }
}
