using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Application.Notification;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.Notification;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletByWithdraw;

internal sealed class UpdateWalletByWithdrawHandler(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    UserManager<ApplicationUser> userManager
) : IRequestHandler<UpdateWalletByWithdrawCommand, Result<WalletDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public async Task<Result<WalletDto>> Handle(
        UpdateWalletByWithdrawCommand request,
        CancellationToken cancellationToken
    )
    {
        var (wallet, transaction) = request.Wallet;

        if (wallet.Balance < request.Amount)
            return Result.Error("Insufficient balance");

        wallet.Balance -= request.Amount;
        wallet.ModifiedOnUtc = DateTimeOffset.UtcNow;

        _unitOfWork.RepositoryWallet.UpdateAsync(wallet);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        await SendNotification(_userManager, request, wallet);

        var walletDto = _mapper.Map<WalletDto>(wallet);
        var transactionDto = _mapper.Map<TransactionDto>(transaction);

        walletDto.Transactions = [transactionDto];

        return Result<WalletDto>.Success(walletDto);
    }

    private static async Task SendNotification(
        UserManager<ApplicationUser> userManager,
        UpdateWalletByWithdrawCommand request,
        Wallet? wallet
    )
    {
        var userToken = await userManager
            .Users.Where(u => u.DeviceToken != null && u.Id == wallet.UserId)
            .Select(u => u.DeviceToken)
            .Distinct()
            .ToListAsync();

        var expoPushClient = new PushExpoApiClient();
        var pushTicketRequest = new PushTicketRequest
        {
            PushTo = userToken!,
            PushTitle = "Withdrawal Request",
            PushBody =
                $"Your withdrawal request has been processed. You withdraw {request.Amount} VND. You current balance is {wallet.Balance} VND",
        };
        await expoPushClient.PushSendAsync(pushTicketRequest);
    }
}
