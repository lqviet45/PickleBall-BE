using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByBooking;

internal sealed class CreateTransactionByBookingHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<CreateTransactionByBookingCommand, Result<TransactionDto>>
{
    public async Task<Result<TransactionDto>> Handle(
        CreateTransactionByBookingCommand request,
        CancellationToken cancellationToken
    )
    {
        var wallet = await unitOfWork.RepositoryWallet.GetEntityByConditionAsync(
            x => x.UserId == request.UserId,
            true,
            cancellationToken
        );

        var courtGroup = await unitOfWork.RepositoryCourtGroup.GetEntityByConditionAsync(
            x => x.Id == request.CourtGroupId,
            false,
            cancellationToken
        );

        wallet.Balance -= courtGroup.Price;

        Transaction transaction =
            new()
            {
                UserId = request.UserId,
                WalletId = wallet.Id,
                BookingId = request.BookingId,
                Amount = courtGroup.Price,
                Description = "Booking",
                TransactionStatus = TransactionStatus.Completed,
                CreatedOnUtc = DateTimeOffset.UtcNow
            };

        unitOfWork.RepositoryTransaction.AddAsync(transaction);
        unitOfWork.RepositoryWallet.UpdateAsync(wallet);

        var transactionDto = mapper.Map<TransactionDto>(transaction);

        return Result.Success(transactionDto);
    }
}
