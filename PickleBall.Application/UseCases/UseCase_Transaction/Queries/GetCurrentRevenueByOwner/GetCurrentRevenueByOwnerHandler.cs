using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.DTOs.TransactionDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetCurrentRevenueByOwner;

internal sealed class GetCurrentRevenueByOwnerHandler(
    IUnitOfWork unitOfWork,
    UserManager<ApplicationUser> userManager
) : IRequestHandler<GetCurrentRevenueByOwnerQuery, Result<CurrentRevenueDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public async Task<Result<CurrentRevenueDto>> Handle(
        GetCurrentRevenueByOwnerQuery request,
        CancellationToken cancellationToken
    )
    {
        var ownerResult = await IsValidOwner(request, cancellationToken);
        if (!ownerResult.IsSuccess)
            return Result.Error(ownerResult.Errors.First());

        var currentDate = DateTime.UtcNow;

        var currentDayRevenue = await GetCurrentDayRevenue(
            request.OwnerId,
            currentDate,
            cancellationToken
        );

        var (TotalRevenue, PlayerCount) = await GetCurrentMonthRevenue(
            request.OwnerId,
            currentDate,
            cancellationToken
        );

        var response = new CurrentRevenueDto
        {
            CurrentDate = currentDate.Date,
            TotalDayRevenue = currentDayRevenue,
            TotalMonthRevenue = TotalRevenue,
            PlayerCountOfMonth = PlayerCount
        };

        return Result.Success(response);
    }

    private async Task<Result<RevenueResponseDto>> IsValidOwner(
        GetCurrentRevenueByOwnerQuery request,
        CancellationToken cancellationToken
    )
    {
        var owner = await _unitOfWork.RepositoryApplicationUser.GetUserByConditionAsync(
            u => u.Id == request.OwnerId,
            request.TrackChanges,
            cancellationToken
        );

        if (owner is null)
            return Result.NotFound("User is not found");

        var roles = await _userManager.GetRolesAsync(owner);
        if (roles.Count == 0)
            return Result.Error("User has no role assigned");

        var role = (Role)Enum.Parse(typeof(Role), roles[0]);
        if (role != Role.Owner)
            return Result.Error("User is not an owner");

        return Result.Success();
    }

    private async Task<decimal> GetCurrentDayRevenue(
        Guid ownerId,
        DateTime date,
        CancellationToken cancellationToken
    )
    {
        var transactions = await _unitOfWork.RepositoryTransaction.GetTransactionsByDayAsync(
            ownerId,
            date,
            false,
            cancellationToken
        );
        var a = date.Date;

        var totalRevenue = transactions.Sum(t => t.Amount);

        return totalRevenue;
    }

    private async Task<(decimal TotalRevenue, int PlayerCount)> GetCurrentMonthRevenue(
        Guid ownerId,
        DateTime date,
        CancellationToken cancellationToken
    )
    {
        var transactions = await _unitOfWork.RepositoryTransaction.GetTransactionsByMonthAsync(
            ownerId,
            date.Month,
            date.Year,
            false,
            cancellationToken
        );

        var bookingDict = await GetBookingDictionaryAsync(transactions, cancellationToken);

        var totalRevenue = transactions.Sum(t => t.Amount);

        var playerCount = transactions.Sum(t =>
            bookingDict.ContainsKey(t.BookingId) ? bookingDict[t.BookingId].NumberOfPlayers : 0
        );

        return (totalRevenue, playerCount);
    }

    private async Task<Dictionary<Guid, Booking>> GetBookingDictionaryAsync(
        IEnumerable<Transaction> transactions,
        CancellationToken cancellationToken
    )
    {
        var bookingIds = transactions.Select(t => t.BookingId).Distinct().ToList();

        var bookings = await _unitOfWork.RepositoryBooking.GetAllBookingsByConditionAsync(
            b => bookingIds.Contains(b.Id),
            false,
            new BookingParameters { PageNumber = 1, PageSize = bookingIds.Count },
            cancellationToken
        );

        return bookings.ToDictionary(b => b.Id);
    }
}
