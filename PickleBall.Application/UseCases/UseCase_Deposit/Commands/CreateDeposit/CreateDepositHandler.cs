using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_Deposit.Commands.CreateDeposit;

internal sealed class CreateDepositHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<CreateDepositCommand, Result<(DepositDto, Wallet)>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<(DepositDto, Wallet)>> Handle(
        CreateDepositCommand request,
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

        Deposit deposit =
            new()
            {
                UserId = request.UserId,
                WalletId = request.WalletId,
                Amount = request.Amount,
                Status = "Completed",
                Description = "Deposit",
                CreatedOnUtc = DateTimeOffset.UtcNow
            };

        _unitOfWork.RepositoryDeposit.AddAsync(deposit);

        var depositDto = _mapper.Map<DepositDto>(deposit);

        return Result.Success((depositDto, wallet));
    }
}
