using Ardalis.Result;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateWithdraw;

internal sealed class CreateWithdrawHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<CreateWithdrawCommand, Result<(Wallet, Transaction)>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result<(Wallet, Transaction)>> Handle(
        CreateWithdrawCommand request,
        CancellationToken cancellationToken
    )
    {
        var user = await _unitOfWork.RepositoryApplicationUser.GetUserByConditionAsync(
            u => u.Id == request.UserId,
            true,
            cancellationToken
        );
        if (user is null)
            return Result.NotFound("User not found");

        var wallet = await _unitOfWork.RepositoryWallet.GetWalletByConditionAsync(
            w => w.Id == request.WalletId,
            true,
            cancellationToken
        );
        if (wallet is null)
            return Result.NotFound("Wallet not found");

        Transaction transaction =
            new()
            {
                UserId = request.UserId,
                WalletId = request.WalletId,
                TransactionStatus = TransactionStatus.Completed,
                Amount = request.Amount,
                Description = "Withdraw",
                CreatedOnUtc = DateTimeOffset.UtcNow
            };

        _unitOfWork.RepositoryTransaction.AddAsync(transaction);

        return Result.Success((wallet, transaction));
    }
}
