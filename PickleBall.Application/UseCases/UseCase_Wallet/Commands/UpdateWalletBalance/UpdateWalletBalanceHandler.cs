using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletBalance;

internal sealed class UpdateWalletBalanceHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<UpdateWalletBalanceCommand, Result<WalletDto>>
{
    public async Task<Result<WalletDto>> Handle(
        UpdateWalletBalanceCommand request,
        CancellationToken cancellationToken
    )
    {
        var courtGroup = await unitOfWork.RepositoryCourtGroup.GetEntityByConditionAsync(
            x => x.Id == request.CourtGroupId,
            false,
            cancellationToken
        );
        if (courtGroup is null)
            return Result.NotFound("Court group not found");

        var wallet = await unitOfWork.RepositoryWallet.GetEntityByConditionAsync(
            x => x.UserId == request.UserId,
            false,
            cancellationToken
        );
        if (wallet == null)
            return Result.NotFound("Wallet not found");

        wallet.Balance -= courtGroup.Price;
        unitOfWork.RepositoryWallet.UpdateAsync(wallet);

        return Result<WalletDto>.Success(mapper.Map<WalletDto>(wallet));
    }
}
