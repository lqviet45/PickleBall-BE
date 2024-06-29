using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Commands.CreateTransactionByBooking;

internal sealed class CreateTransactionByBookingHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<CreateTransactionByBookingCommand, Result>
{
    public async Task<Result> Handle(
        CreateTransactionByBookingCommand request,
        CancellationToken cancellationToken
    )
    {
        CreateUserTransaction(unitOfWork, request);

        CreateOwnerTransaction(unitOfWork, request);

        return Result.Success();
    }

    private static void CreateUserTransaction(
        IUnitOfWork unitOfWork,
        CreateTransactionByBookingCommand request
    )
    {
        Transaction userTransaction =
            new()
            {
                UserId = request.UserWallet.UserId,
                WalletId = request.UserWallet.Id,
                BookingId = request.BookingId,
                Amount = request.CourtGroup.Price,
                Description = "Booking",
                TransactionStatus = TransactionStatus.Completed,
                CreatedOnUtc = DateTimeOffset.UtcNow
            };

        unitOfWork.RepositoryTransaction.AddAsync(userTransaction);
    }

    private static void CreateOwnerTransaction(
        IUnitOfWork unitOfWork,
        CreateTransactionByBookingCommand request
    )
    {
        Transaction ownerTransaction =
            new()
            {
                UserId = request.OwnerWallet.UserId,
                WalletId = request.OwnerWallet.Id,
                BookingId = request.BookingId,
                Amount = request.CourtGroup.Price,
                Description = "Booking Income",
                TransactionStatus = TransactionStatus.Completed,
                CreatedOnUtc = DateTimeOffset.UtcNow
            };

        unitOfWork.RepositoryTransaction.AddAsync(ownerTransaction);
    }
}
