using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_Wallet.Commands.UpdateWalletBalance;

internal sealed class UpdateWalletBalanceHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<
        UpdateWalletBalanceCommand,
        Result<(Wallet userWallet, Wallet ownerWallet, CourtGroup)>
    >
{
    public async Task<Result<(Wallet? userWallet, Wallet? ownerWallet, CourtGroup)>> Handle(
        UpdateWalletBalanceCommand request,
        CancellationToken cancellationToken
    )
    {
        var courtGroup = await unitOfWork.RepositoryCourtGroup.GetEntityByConditionAsync(
            x => x.Id == request.CourtGroupId,
            false,
            cancellationToken
        );
        if (courtGroup is null)
            return Result.NotFound("Court group not found");

        var booking = await unitOfWork.RepositoryBooking.GetBookingByIdAsync(
            request.BookingId,
            false,
            cancellationToken
        );

        var slotCount = booking.SlotBookings.Count;

        var ownerWallet = await UpdateOwnerWallet(
            courtGroup,
            courtGroup.Price * slotCount,
            cancellationToken
        );
        if (!ownerWallet.IsSuccess)
            return Result.Error(ownerWallet.Errors.First());

        var userWallet = await UpdateUserWallet(
            request,
            courtGroup.Price * slotCount,
            cancellationToken
        );
        if (!userWallet.IsSuccess)
            return Result.Error(userWallet.Errors.First());

        return Result.Success((userWallet.Value, ownerWallet.Value, courtGroup));
    }

    private async Task<Result<Wallet?>> UpdateOwnerWallet(
        CourtGroup courtGroup,
        decimal amount,
        CancellationToken cancellationToken
    )
    {
        var ownerWallet = await unitOfWork.RepositoryWallet.GetEntityByConditionAsync(
            x => x.UserId == courtGroup.UserId,
            false,
            cancellationToken
        );
        if (ownerWallet == null)
            return Result.NotFound("Owner wallet not found");

        ownerWallet.Balance += amount;
        ownerWallet.ModifiedOnUtc = DateTimeOffset.UtcNow;

        unitOfWork.RepositoryWallet.UpdateAsync(ownerWallet);

        return mapper.Map<Wallet>(ownerWallet);
    }

    private async Task<Result<Wallet?>> UpdateUserWallet(
        UpdateWalletBalanceCommand request,
        decimal amount,
        CancellationToken cancellationToken
    )
    {
        var userWallet = await unitOfWork.RepositoryWallet.GetEntityByConditionAsync(
            x => x.UserId == request.UserId,
            false,
            cancellationToken
        );
        if (userWallet == null)
            return Result.NotFound("User wallet not found");

        userWallet.Balance -= amount;
        userWallet.ModifiedOnUtc = DateTimeOffset.UtcNow;

        if (userWallet.Balance < 0)
            return Result.Error("Insufficient funds");

        unitOfWork.RepositoryWallet.UpdateAsync(userWallet);

        return mapper.Map<Wallet>(userWallet);
    }
}
