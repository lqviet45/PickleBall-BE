using Ardalis.Result;
using MediatR;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateWithdraw;

public class CreateWithdrawCommand : IRequest<Result<(Wallet, Transaction)>>
{
    public Guid WalletId { get; set; }
    public Guid UserId { get; set; }
    public decimal Amount { get; set; }
}
