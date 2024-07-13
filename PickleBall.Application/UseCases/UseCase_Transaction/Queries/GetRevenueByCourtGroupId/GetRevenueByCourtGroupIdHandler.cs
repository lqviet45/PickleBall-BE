using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueByOwner;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.DTOs.TransactionDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;
using PickleBall.Domain.Paging;
using System.Globalization;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueByCourtGroupId
{
    internal sealed class GetRevenueByCourtGroupIdHandler : IRequestHandler<GetRevenueByCourtGroupIdQuery, Result<RevenueResponseDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetRevenueByCourtGroupIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<RevenueResponseDto>> Handle(GetRevenueByCourtGroupIdQuery request, CancellationToken cancellationToken)
        {
            var courtGroup = await IsValidRequest(request, cancellationToken);
            if (!courtGroup.IsSuccess)
                return Result.NotFound("CourtGroup is not found");

            List<RevenueDto> groupedTransactions = await GetTransactions(request, cancellationToken);

            var response = new RevenueResponseDto { Weeks = groupedTransactions };

            return response;
        }

        private async Task<Result<RevenueResponseDto>> IsValidRequest(
        GetRevenueByCourtGroupIdQuery request,
        CancellationToken cancellationToken
    )
        {
            var courtGroup = await _unitOfWork.RepositoryCourtGroup.GetEntityByConditionAsync(
                u => u.Id == request.CourtGroupId,
                request.TrackChanges,
                cancellationToken
            );

            if (courtGroup is null)
                return Result.NotFound("CourtGroup is not found");

            return Result.Success();
        }

        private async Task<List<RevenueDto>> GetTransactions(
        GetRevenueByCourtGroupIdQuery request,
        CancellationToken cancellationToken
    )
        {
            // Get transactions by month, year and courtgroup id
            var transactions = await _unitOfWork.RepositoryTransaction.GetEntitiesByConditionAsync(
                t => t.Booking != null && t.Booking.CourtGroupId == request.CourtGroupId
                    && t.CreatedOnUtc.Month == request.Month
                    && t.CreatedOnUtc.Year == request.Year
                    && t.TransactionStatus == TransactionStatus.Completed
                    && t.Description == "Booking Income",
                request.TrackChanges,
                cancellationToken,
                t => t.Include(t => t.Booking)
                .OrderByDescending(t => t.CreatedOnUtc)
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

            // Calculate the first day of the week for the beginning of the month
            int daysOffset = (int)beginningOfMonth.DayOfWeek - (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
            if (daysOffset < 0)
                daysOffset += 7;

            // Calculate the first week containing the first day of the month
            DateTime firstWeekStart = beginningOfMonth.AddDays(-daysOffset);

            // Calculate the difference in weeks between the input date and the first week start
            return (int)Math.Ceiling((double)(date.Subtract(firstWeekStart).Days + 1) / 7);
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
}
