using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_Deposit.Commands.CreateDeposit;

public class CreateDepositCommand : IRequest<Result<(DepositDto, Wallet)>>
{
    public Guid WalletId { get; set; }
    public Guid UserId { get; set; }
    public decimal Amount { get; set; }
}
