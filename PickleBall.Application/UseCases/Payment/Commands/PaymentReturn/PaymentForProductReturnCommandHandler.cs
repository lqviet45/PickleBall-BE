using Ardalis.Result;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.Payment.Commands.PaymentReturn;

public class PaymentForProductReturnCommandHandler : IRequestHandler<PaymentForProductReturnCommand, Result>
{
    private readonly IUnitOfWork _unitOfWork;

    public PaymentForProductReturnCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(PaymentForProductReturnCommand request, CancellationToken cancellationToken)
    {
        var transaction = await _unitOfWork.RepositoryTransaction.GetEntityByConditionAsync(
            x => x.OrderCode == request.OrderCode,
            trackChanges: true,
            cancellationToken
        );
        
        if (transaction is null)
        {
            return Result.NotFound();
        }
        
        if (request.Cancel)
        {
            transaction.TransactionStatus = TransactionStatus.Cancelled;
        }
        else if (request.Status == "PAID")
        {
            transaction.TransactionStatus = TransactionStatus.Completed;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result.Success();
    }
}