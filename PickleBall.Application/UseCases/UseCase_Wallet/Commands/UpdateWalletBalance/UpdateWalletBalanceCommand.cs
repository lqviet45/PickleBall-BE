using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletBalance;

public class UpdateWalletBalanceCommand : IRequest<Result<WalletDto>>
{
    public Guid UserId { get; set; }
    public Guid CourtGroupId { get; set; }
}
