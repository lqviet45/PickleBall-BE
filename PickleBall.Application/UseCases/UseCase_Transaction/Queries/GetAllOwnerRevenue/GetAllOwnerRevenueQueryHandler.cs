using System.Globalization;
using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.DTOs.TransactionDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllOwnerRevenue;

public class GetAllOwnerRevenueQueryHandler : IRequestHandler<GetAllOwnerRevenueQuery, Result<RevenueByAllOwnerResponseDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ITransactionProductRepository _transactionProductRepository;

    public GetAllOwnerRevenueQueryHandler(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, ITransactionProductRepository transactionProductRepository)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
        _transactionProductRepository = transactionProductRepository;
    }

    public async Task<Result<RevenueByAllOwnerResponseDto>> Handle(GetAllOwnerRevenueQuery request, CancellationToken cancellationToken)
    {
        var owners = (await _userManager.GetUsersInRoleAsync(Role.Owner.ToString()))
            .Select(u => u.Id)
            .ToList();
        
        var booking = await _unitOfWork.RepositoryBooking
            .GetQueryable()
            .Where(b => owners.Contains(b.CourtGroup.UserId)
                        && b.BookingStatus == BookingStatus.Completed
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

        var transactionProducts = await _transactionProductRepository.GetAllAsync(
                false,
                cancellationToken
            );
        
        var toltal = revenue.Sum(t => t.Amount);
        var calendar = CultureInfo.InvariantCulture.Calendar;
        
        var totalRevenueByWeek = revenue
            .GroupBy(t => GetWeekOfMonth(t.CreatedOnUtc.Date, calendar))
            .Select(t => new RevenueByAllOwnerDto()
            {
                Week = "week " + t.Key,
                TotalRevenue = t.Sum(x => x.Amount),
                TotalBookings = booking.Count(b => GetWeekOfMonth(b.CreatedOnUtc.Date, calendar) == t.Key),
                TotalProducts = transactionProducts
                    .Where(tp => GetWeekOfMonth(tp.CreatedOnUtc.Date, calendar) == t.Key)  // Ensure the week of the product matches
                    .Sum(tp => tp.Quantity)
            })
            .OrderBy(t => t.Week)
            .ToList();
        
        var totalRevenue = totalRevenueByWeek.Sum(t => t.TotalRevenue);
        var totalBookings = totalRevenueByWeek.Sum(t => t.TotalBookings);
        
        var totalRevenueByMonth = new RevenueByAllOwnerResponseDto()
        {
            TotalRevenue = totalRevenue,
            TotalBookings = totalBookings,
            Weeks = totalRevenueByWeek,
            TotalProducts = totalRevenueByWeek.Sum(t => t.TotalProducts)
        };
        
        return Result<RevenueByAllOwnerResponseDto>.Success(totalRevenueByMonth);
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