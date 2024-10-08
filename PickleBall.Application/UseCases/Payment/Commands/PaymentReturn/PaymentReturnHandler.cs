using Ardalis.Result;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.Payment.Commands.PaymentReturn;

public class PaymentReturnHandler : IRequestHandler<PaymentReturnCommand, Result>
{
    private readonly IUnitOfWork _unitOfWork;
    
    public PaymentReturnHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(PaymentReturnCommand request, CancellationToken cancellationToken)
    {
        var transaction = await _unitOfWork.RepositoryTransaction.GetEntityByConditionAsync(
            x => x.OrderCode == request.OrderCode && x.UserId == request.CustomerId,
            trackChanges: true,
            cancellationToken
        );
        
        
        if (transaction == null)
        {
            return Result.NotFound();
        }
        
        var booking = await _unitOfWork.RepositoryBooking.GetBookingByIdAsync(
            transaction.BookingId,
            trackChanges: true,
            cancellationToken
        );
        
        if (booking == null)
        {
            return Result.NotFound();
        }

        var transactionOwner = await _unitOfWork.RepositoryTransaction
            .GetQueryable()
            .Where(x => x.OrderCode == request.OrderCode
                        && x.BookingId == booking.Id
                        && x.UserId == booking.CourtGroup.UserId)
            .FirstOrDefaultAsync(cancellationToken: cancellationToken);
        
        if (transactionOwner == null) return Result.NotFound();
        
        var wallet = await _unitOfWork.RepositoryWallet.GetWalletByConditionAsync(
            x => x.UserId == request.CustomerId,
            trackChanges: true,
            cancellationToken
        );
        
        var walletOwner = await _unitOfWork.RepositoryWallet.GetWalletByConditionAsync(
            x => x.UserId == booking.CourtGroup.UserId,
            trackChanges: true,
            cancellationToken
        );
        
        if (wallet == null || walletOwner == null)
        {
            return Result.NotFound();
        }
        
        if (request.Cancel)
        {
            transaction.TransactionStatus = TransactionStatus.Cancelled;
            transactionOwner.TransactionStatus = TransactionStatus.Cancelled;
        }
        else if (request.Status == "PAID")
        {
            transaction.TransactionStatus = TransactionStatus.Completed;
            transactionOwner.TransactionStatus = TransactionStatus.Completed;
            wallet.Balance -= transaction.Amount;
            walletOwner.Balance += transaction.Amount;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}