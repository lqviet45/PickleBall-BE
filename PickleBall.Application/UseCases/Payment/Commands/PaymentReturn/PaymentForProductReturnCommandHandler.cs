using Ardalis.Result;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.Payment.Commands.PaymentReturn;

public class PaymentForProductReturnCommandHandler : IRequestHandler<PaymentForProductReturnCommand, Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProductRepository _productRepository;
    public PaymentForProductReturnCommandHandler(IUnitOfWork unitOfWork, IProductRepository productRepository)
    {
        _unitOfWork = unitOfWork;
        _productRepository = productRepository;
    }

    public async Task<Result> Handle(PaymentForProductReturnCommand request, CancellationToken cancellationToken)
    {
        var transaction = await _unitOfWork.RepositoryTransaction.GetEntityByConditionAsync(
            x => x.OrderCode == request.OrderCode && x.UserId == request.CustomerId,
            trackChanges: true,
            cancellationToken,
            x => x.Include(tp => tp.TransactionProducts)
                .ThenInclude(tp => tp.Product)
        );
        
        
        if (transaction is null)
        {
            return Result.NotFound();
        }
        
        var courtGroupIds = transaction
            .TransactionProducts
            .Select(x => x.Product?.CourtGroupId)
            .ToList();

        var ownerId = await _unitOfWork.RepositoryCourtGroup
            .GetQueryable()
            .Where(x => courtGroupIds.Contains(x.Id))
            .Select(x => x.UserId)
            .Distinct()
            .ToListAsync(cancellationToken: cancellationToken);
        
        var transactionOwner = await _unitOfWork.RepositoryTransaction
            .GetQueryable()
            .Where(x => ownerId.Contains(x.UserId) && x.OrderCode == request.OrderCode)
            .ToListAsync(cancellationToken: cancellationToken);
        
        if (request.Cancel)
        {
            transaction.TransactionStatus = TransactionStatus.Cancelled;
            foreach (var item in transactionOwner)
            {
                item.TransactionStatus = TransactionStatus.Cancelled;
            }
        }
        else if (request.Status == "PAID")
        {
            transaction.TransactionStatus = TransactionStatus.Completed;

            foreach (var tp in transaction.TransactionProducts)
            {
                tp.Product!.Quantity -= tp.Quantity;
            }
            
            foreach (var item in transactionOwner)
            {
                item.TransactionStatus = TransactionStatus.Completed;
                var wallet = await _unitOfWork.RepositoryWallet.GetEntityByConditionAsync(
                    x => x.UserId == item.UserId,
                    false,
                    cancellationToken
                );
                wallet!.Balance += item.Amount;
            }
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result.Success();
    }
}