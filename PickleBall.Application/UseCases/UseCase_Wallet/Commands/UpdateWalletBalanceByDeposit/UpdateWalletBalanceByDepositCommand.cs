using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletBalanceByDeposit;

public class UpdateWalletBalanceByDepositCommand : IRequest<Result<WalletDto>>
{
    public Guid UserId { get; set; }
    public Wallet Wallet { get; set; }
    public decimal Amount { get; set; }
}
