using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletBalance;

public class UpdateWalletBalanceCommand
    : IRequest<Result<(Wallet userWallet, Wallet ownerWallet, CourtGroup)>>
{
    public Guid UserId { get; set; }
    public Guid CourtGroupId { get; set; }
    public Guid BookingId { get; set; }
}
