using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Net.payOS.Types;
using PickleBall.Application.Abstractions;
using PickleBall.Application.UseCases.Abstraction;
using PickleBall.Contract.Models;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.Payment.Commands;

public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, Result<CreatePaymentResult>>
{
    private readonly IPayOsService _payOsService;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;

    public CreatePaymentCommandHandler(IPayOsService payOsService, UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
    {
        _payOsService = payOsService;
        _userManager = userManager;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<CreatePaymentResult>> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByIdAsync(request.userId.ToString());
        
        if (user == null)
        {
            return Result<CreatePaymentResult>.NotFound();
        }

        var wallet = await _unitOfWork.RepositoryWallet.GetWalletByConditionAsync(
            x => x.UserId == request.userId,
            trackChanges: true,
            cancellationToken
        );
        
        if (wallet == null)
        {
            var walletEntity = new Wallet
            {
                UserId = request.userId,
                Balance = 0
            };
            
            user.Wallets = walletEntity;
            await _userManager.UpdateAsync(user);

            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        var deposit = new Deposit()
        {
            UserId = request.userId,
            WalletId = wallet!.Id,
            OrderId = 0,
            Amount = request.price,
            Status = "Pending",
            Description = request.description,
            CreatedOnUtc = DateTimeOffset.Now
        };

        
        
        var paymentItems = new List<PaymentItem>
        {
            new PaymentItem
            {
                Name = request.name,
                Price = request.price,
                Quantity = 1
            }
        };
        
        var result = await _payOsService.CreatePayment(request.price, paymentItems, request.returnUrl, request.cancelUrl, request.description);
        
        deposit.OrderId = result.orderCode;
        
        _unitOfWork.RepositoryDeposit.AddAsync(deposit);
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<CreatePaymentResult>.Success(result);
    }
}