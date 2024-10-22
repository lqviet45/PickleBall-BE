using System.Globalization;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.TransactionDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueByOwnerId;

public class GetRevenueByOwnerIdQueryHandler : IRequestHandler<GetRevenueByOwnerIdQuery, Result<RevenueByOwnerIdResponseDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<ApplicationUser> _userManager;

    public GetRevenueByOwnerIdQueryHandler(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public async Task<Result<RevenueByOwnerIdResponseDto>> Handle(GetRevenueByOwnerIdQuery request, CancellationToken cancellationToken)
    {
        var owners = await _userManager.Users
            .Where(u => u.Id == request.OwnerId)
            .FirstOrDefaultAsync(cancellationToken);
        
        if (owners == null)
        {
            return Result<RevenueByOwnerIdResponseDto>.NotFound();
        }
        
        var booking = await _unitOfWork.RepositoryBooking
            .GetQueryable()
            .Where(b => b.CourtGroup.UserId == request.OwnerId
                        && b.BookingStatus == BookingStatus.Completed
                        && b.CreatedOnUtc.Month == request.Month
                        && b.CreatedOnUtc.Year == request.Year)
            .AsTracking()
            .ToListAsync(cancellationToken: cancellationToken);

        var revenue = await _unitOfWork.RepositoryTransaction
            .GetQueryable()
            .Where(t => t.UserId == request.OwnerId
                        && t.CreatedOnUtc.Month == request.Month
                        && t.CreatedOnUtc.Year == request.Year
                        && t.TransactionStatus == TransactionStatus.Completed)
            .AsTracking()
            .ToListAsync(cancellationToken: cancellationToken);
        
        var calendar = CultureInfo.InvariantCulture.Calendar;
        
        var totalRevenueByWeek = revenue
            .GroupBy(t => GetWeekOfMonth(t.CreatedOnUtc.Date, calendar))
            .Select(t => new RevenueByOwnerIdDto()
            {
                Week = "week " + t.Key,
                TotalRevenue = t.Sum(x => x.Amount),
                TotalBookings = booking.Count(b => GetWeekOfMonth(b.CreatedOnUtc.Date, calendar) == t.Key)
            })
            .OrderBy(t => t.Week)
            .ToList();
        
        var totalRevenue = totalRevenueByWeek.Sum(t => t.TotalRevenue);
        var totalBookings = totalRevenueByWeek.Sum(t => t.TotalBookings);
        
        var totalRevenueByMonth = new RevenueByOwnerIdResponseDto()
        {
            TotalRevenue = totalRevenue,
            TotalBookings = totalBookings,
            Weeks = totalRevenueByWeek
        };
        
        return Result<RevenueByOwnerIdResponseDto>.Success(totalRevenueByMonth);
    }
    
    private static int GetWeekOfMonth(DateTime date, Calendar calendar)
    {
        var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);

        // Find the first Monday of the month
        var firstMonday = firstDayOfMonth;
        while (firstMonday.DayOfWeek != DayOfWeek.Monday)
        {
            firstMonday = firstMonday.AddDays(1);
        }

        // Calculate the number of full weeks between the first Monday and the given date
        var daysDifference = (date - firstMonday).Days;
        return (daysDifference / 7) + 1;
    }
}