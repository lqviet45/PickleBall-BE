using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByDeposit;

internal sealed class CreateTransactionByDepositHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<CreateTransactionByDepositCommand, Result<TransactionDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<TransactionDto>> Handle(
        CreateTransactionByDepositCommand request,
        CancellationToken cancellationToken
    )
    {
        Transaction transaction =
            new()
            {
                UserId = request.UserId,
                WalletId = request.WalletId,
                DepositId = request.DepositId,
                Amount = request.Amount,
                TransactionStatus = TransactionStatus.Completed,
                Description = "Deposit",
                CreatedOnUtc = DateTimeOffset.UtcNow
            };

        _unitOfWork.RepositoryTransaction.AddAsync(transaction);

        var transactionDto = _mapper.Map<TransactionDto>(transaction);

        return Result.Success(transactionDto);
    }
}
