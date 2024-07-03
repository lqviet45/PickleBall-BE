using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletBalanceByDeposit;

internal sealed class UpdateWalletBalanceByDepositHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<UpdateWalletBalanceByDepositCommand, Result<WalletDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<WalletDto>> Handle(
        UpdateWalletBalanceByDepositCommand request,
        CancellationToken cancellationToken
    )
    {
        request.Wallet.Balance += request.Amount;
        request.Wallet.ModifiedOnUtc = DateTimeOffset.UtcNow;

        _unitOfWork.RepositoryWallet.UpdateAsync(request.Wallet);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var walletDto = _mapper.Map<WalletDto>(request.Wallet);
        var transactionDto = _mapper.Map<TransactionDto>(request.Transaction);

        walletDto.Transactions = [transactionDto];

        return Result<WalletDto>.Success(walletDto);
    }
}
