using Ardalis.Result;
using MediatR;
using PickleBall.Application.Abstractions;

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
        var deposit = await _unitOfWork.RepositoryDeposit.GetEntityByConditionAsync(
            x => x.OrderId == request.OrderCode,
            trackChanges: true,
            cancellationToken
        );
        
        
        if (deposit == null)
        {
            return Result.NotFound();
        }
        
        var wallet = await _unitOfWork.RepositoryWallet.GetWalletByConditionAsync(
            x => x.UserId == deposit.WalletId,
            trackChanges: true,
            cancellationToken
        );
        
        if (wallet == null)
        {
            return Result.NotFound();
        }
        
        if (request.Cancel)
        {
            deposit.Status = "Canceled";
        }
        else if (request.Status == "PAID")
        {
            deposit.Status = "completed";
            wallet.Balance += deposit.Amount;
        }
        else
        {
            deposit.Status = request.Status;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}