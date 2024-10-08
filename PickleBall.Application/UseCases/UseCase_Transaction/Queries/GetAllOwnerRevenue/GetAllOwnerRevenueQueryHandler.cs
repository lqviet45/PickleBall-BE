using System.Globalization;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.DTOs.TransactionDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllOwnerRevenue;

public class GetAllOwnerRevenueQueryHandler : IRequestHandler<GetAllOwnerRevenueQuery, Result<List<RevenueByAllOwnerDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<ApplicationUser> _userManager;

    public GetAllOwnerRevenueQueryHandler(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public async Task<Result<List<RevenueByAllOwnerDto>>> Handle(GetAllOwnerRevenueQuery request, CancellationToken cancellationToken)
    {
        var owners = (await _userManager.GetUsersInRoleAsync(Role.Owner.ToString()))
            .Select(u => u.Id)
            .ToList();
        
        var booking = await _unitOfWork.RepositoryBooking
            .GetQueryable()
            .Where(b => owners.Contains(b.CourtGroup.UserId)
                        && b.CreatedOnUtc.Month == request.Month
                        && b.CreatedOnUtc.Year == request.Year)
            .AsTracking()
            .ToListAsync(cancellationToken: cancellationToken);

        var revenue = await _unitOfWork.RepositoryTransaction
            .GetQueryable()
            .Where(t => owners.Contains(t.UserId)
                        && t.CreatedOnUtc.Month == request.Month
                        && t.CreatedOnUtc.Year == request.Year
                        && t.TransactionStatus == TransactionStatus.Completed)
            .AsTracking()
            .ToListAsync(cancellationToken: cancellationToken);
        
        var calendar = CultureInfo.InvariantCulture.Calendar;
        var totalRevenueByWeek = revenue
            .GroupBy(t => GetWeekOfMonth(t.CreatedOnUtc.Date, calendar))
            .Select(t => new RevenueByAllOwnerDto()
            {
                Week = "week " + t.Key,
                TotalRevenue = t.Sum(x => x.Amount),
                TotalBookings = booking.Count(b => GetWeekOfMonth(b.CreatedOnUtc.Date, calendar) == t.Key)
            })
            .OrderBy(t => t.Week)
            .ToList();
        
        var totalRevenue = totalRevenueByWeek.Sum(t => t.TotalRevenue);
        
        return Result<List<RevenueByAllOwnerDto>>.Success(totalRevenueByWeek);
    }
    
    private static int GetWeekOfMonth(DateTime date, Calendar calendar)
    {
        var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
        var firstWeekOfMonth = calendar.GetWeekOfYear(firstDayOfMonth, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        var currentWeek = calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);

        return currentWeek - firstWeekOfMonth + 1;  // Subtract to get relative week of the month
    }
}