using System.Globalization;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.DTOs.TransactionDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueByOwner;

internal sealed class GetRevenueByOwnerHandler(
    IUnitOfWork unitOfWork,
    UserManager<ApplicationUser> userManager
) : IRequestHandler<GetRevenueByOwnerQuery, Result<RevenueResponseDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public async Task<Result<RevenueResponseDto>> Handle(
        GetRevenueByOwnerQuery request,
        CancellationToken cancellationToken
    )
    {
        var ownerResult = await IsValidOwner(request, cancellationToken);
        if (!ownerResult.IsSuccess)
            return Result.Error(ownerResult.Errors.First());

        List<RevenueDto> groupedTransactions = await GetTransactions(request, cancellationToken);

        var response = new RevenueResponseDto { Weeks = groupedTransactions };

        return response;
    }

    private async Task<Result<RevenueResponseDto>> IsValidOwner(
        GetRevenueByOwnerQuery request,
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

    private async Task<List<RevenueDto>> GetTransactions(
        GetRevenueByOwnerQuery request,
        CancellationToken cancellationToken
    )
    {
        // Get transactions by month, year and owner id
        var transactions = await _unitOfWork.RepositoryTransaction.GetTransactionsByMonthAsync(
            request.OwnerId,
            request.Month,
            request.Year,
            request.TrackChanges,
            cancellationToken
        );

        var bookingDict = await GetBookingDictionaryAsync(
            transactions,
            request.TrackChanges,
            cancellationToken
        );

        var groupedTransactions = GroupTransactionsByWeek(transactions, bookingDict);

        EnsureAllWeeksArePresent(groupedTransactions);

        // Order by week number
        groupedTransactions = groupedTransactions
            .OrderBy(x => int.Parse(x.Week.Replace("week", "")))
            .ToList();

        return groupedTransactions;
    }

    private async Task<Dictionary<Guid, Booking>> GetBookingDictionaryAsync(
        IEnumerable<Transaction> transactions,
        bool trackChanges,
        CancellationToken cancellationToken
    )
    {
        // Get all bookings by booking ids
        var bookingIds = transactions.Select(t => t.BookingId).Distinct().ToList();

        var bookings = await _unitOfWork.RepositoryBooking.GetAllBookingsByConditionAsync(
            b => bookingIds.Contains(b.Id),
            trackChanges,
            new BookingParameters { PageNumber = 1, PageSize = bookingIds.Count },
            cancellationToken
        );

        return bookings.ToDictionary(b => b.Id);
    }

    private List<RevenueDto> GroupTransactionsByWeek(
        IEnumerable<Transaction> transactions,
        Dictionary<Guid, Booking> bookingDict
    )
    {
        return transactions
            .GroupBy(t => GetWeekOfMonth(t.CreatedOnUtc.DateTime))
            .Select(g => new RevenueDto
            {
                Week = $"week{g.Key}",
                TotalRevenue = g.Sum(x => x.Amount),
                PlayerCount = g.Sum(x =>
                    bookingDict.ContainsKey(x.BookingId)
                        ? bookingDict[x.BookingId].NumberOfPlayers
                        : 0
                )
            })
            .OrderBy(x => x.Week)
            .ToList();
    }

    private int GetWeekOfMonth(DateTime date)
    {
        DateTime beginningOfMonth = new DateTime(date.Year, date.Month, 1);

        // Find the first day of the week
        while (
            date.Date.AddDays(1).DayOfWeek
            != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek
        )
            date = date.AddDays(1);

        return (int)Math.Ceiling((double)(date.Day - beginningOfMonth.Day) / 7) + 1;
    }

    private void EnsureAllWeeksArePresent(List<RevenueDto> groupedTransactions)
    {
        const int maxWeeks = 4;
        for (int i = 1; i <= maxWeeks; i++)
        {
            if (!groupedTransactions.Exists(x => x.Week == $"week{i}"))
            {
                groupedTransactions.Add(
                    new RevenueDto
                    {
                        Week = $"week{i}",
                        TotalRevenue = 0,
                        PlayerCount = 0
                    }
                );
            }
        }
    }
}
