using System.Collections.Immutable;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Net.payOS.Types;
using PickleBall.Application.Abstractions;
using PickleBall.Application.UseCases.Abstraction;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Contract.Models;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;
using Transaction = PickleBall.Domain.Entities.Transaction;

namespace PickleBall.Application.UseCases.Payment.Commands.CreatePaymentForProduct;

public class CreatePaymentForProductCommandHandler : IRequestHandler<CreatePaymentForProductCommand, Result<CreatePaymentResult>>
{
    private readonly IPayOsService _payOsService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITransactionProductRepository _transactionProductRepository;
    private readonly IProductRepository _productRepository;
    private readonly UserManager<ApplicationUser> _userManager;

    public CreatePaymentForProductCommandHandler(IPayOsService payOsService, IUnitOfWork unitOfWork, IProductRepository productRepository, ITransactionProductRepository transactionProductRepository, UserManager<ApplicationUser> userManager)
    {
        _payOsService = payOsService;
        _unitOfWork = unitOfWork;
        _productRepository = productRepository;
        _transactionProductRepository = transactionProductRepository;
        _userManager = userManager;
    }

    public async Task<Result<CreatePaymentResult>> Handle(CreatePaymentForProductCommand request, CancellationToken cancellationToken)
    {
        var products = (await _productRepository.GetEntitiesByConditionAsync(
            p => request.Products.Select(pd => pd.ProductId).Contains(p.Id)
            , false, 
            cancellationToken,
            p => p.Include(p => p.CourtGroup)
            ))
            .ToImmutableList();

        if (products.Count != request.Products.Count)
        {
            throw new Exception("Some products are not found");
        }
        
        var wallet = await _unitOfWork.RepositoryWallet.GetEntityByConditionAsync(
            w => w.UserId == request.UserId,
            false,
            cancellationToken
        );
        var ownerIds = products
            .Where(p => p.CourtGroup is not null)
            .Select(p => p.CourtGroup!.UserId)
            .Distinct()
            .ToImmutableList();
        
        var walletOwner = await _unitOfWork.RepositoryWallet.GetEntitiesByConditionAsync(
            w => ownerIds.Contains(w.UserId),
            false,
            cancellationToken
        );
        
        if (wallet is null)
        {
            wallet = new Wallet()
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                Balance = 0,
                CreatedOnUtc = DateTimeOffset.Now
            };
            
            _unitOfWork.RepositoryWallet.AddAsync(wallet);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        var walletOwnerList = walletOwner.ToList();
        if (walletOwnerList.Count != ownerIds.Count)
        {
            var missingOwnerIds = ownerIds
                .Except(walletOwnerList.Select(w => w.UserId))
                .ToImmutableList();

            foreach (var missingOwnerId in missingOwnerIds)
            {
                var missingWallet = new Wallet()
                {
                    Id = Guid.NewGuid(),
                    UserId = missingOwnerId,
                    Balance = 0,
                    CreatedOnUtc = DateTimeOffset.Now
                };
                
                walletOwnerList.Add(missingWallet);
                _unitOfWork.RepositoryWallet.AddAsync(missingWallet);
            }
        }
        
        var paymentItems = products
            .Select(p => new PaymentItem
            {
                Name = p.ProductName!,
                Price = Convert.ToInt32(p.Price),
                Quantity = request.Products.First(pd => pd.ProductId == p.Id).Quantity
            })
            .ToList();
        
        var totalAmount = paymentItems.Sum(p => p.Price * p.Quantity);
        var orderCode = await _unitOfWork.RepositoryTransaction
            .GetQueryable()
            .MaxAsync(t => t.OrderCode, cancellationToken: cancellationToken);
        
        var result = await _payOsService.CreatePayment(
            totalAmount,
            paymentItems,
            request.ReturnUrl!,
            request.CancelUrl!,
            request.Description ?? "",
            orderCode + 1
        );
        
        var transaction = new Domain.Entities.Transaction()
        {
            Id = Guid.NewGuid(),
            UserId = request.UserId,
            BookingId = Guid.Empty,
            Description = request.Description,
            Amount = totalAmount,
            WalletId = wallet.Id,
            OrderCode = result.orderCode,
            TransactionStatus = TransactionStatus.Pending,
            CreatedOnUtc = DateTimeOffset.Now
        };
        
        List<Transaction> transactionOwner = walletOwnerList.Select(walletOwn => new Domain.Entities.Transaction()
            {
                Id = Guid.NewGuid(),
                UserId = walletOwn.UserId,
                BookingId = Guid.Empty,
                Description = request.Description,
                Amount = totalAmount,
                WalletId = walletOwn.Id,
                OrderCode = result.orderCode,
                TransactionStatus = TransactionStatus.Pending,
                CreatedOnUtc = DateTimeOffset.Now
            })
            .ToList();

        _unitOfWork.RepositoryTransaction.AddAsync(transaction);
        _unitOfWork.RepositoryTransaction.AddRange(transactionOwner);
        
        var transactionProducts = products
            .Select(p => new TransactionProduct()
            {
                ProductId = p.Id,
                Price = p.Price,
                Quantity = request.Products.First(pd => pd.ProductId == p.Id).Quantity,
                TransactionId = transaction.Id,
                CreatedOnUtc = DateTimeOffset.Now
            })
            .ToList();
        
        _transactionProductRepository.AddRange(transactionProducts);
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return Result<CreatePaymentResult>.Success(result);
    }
}