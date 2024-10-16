using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.DTOs.TransactionDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllOwnerRevenueToday;

public class GetAllOwnerRevenueTodayQueryHandler : IRequestHandler<GetAllOwnerRevenueTodayQuery, Result<RevenueByAllOwnerTodayResponseDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<ApplicationUser> _userManager;

    public GetAllOwnerRevenueTodayQueryHandler(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public async Task<Result<RevenueByAllOwnerTodayResponseDto>> Handle(GetAllOwnerRevenueTodayQuery request, CancellationToken cancellationToken)
    {
        // Get the list of owners
        var owners = (await _userManager.GetUsersInRoleAsync(Role.Owner.ToString()))
            .Select(u => u.Id)
            .ToList();

        // Filter for today's bookings
        var today = DateTime.UtcNow.Date;

        var booking = await _unitOfWork.RepositoryBooking
            .GetQueryable()
            .Where(b => owners.Contains(b.CourtGroup.UserId)
                        && b.BookingStatus == BookingStatus.Completed
                        && b.CreatedOnUtc.Date == today)
            .AsTracking()
            .ToListAsync(cancellationToken: cancellationToken);

        // Filter for today's transactions
        var revenue = await _unitOfWork.RepositoryTransaction
            .GetQueryable()
            .Where(t => owners.Contains(t.UserId)
                        && t.CreatedOnUtc.Date == today
                        && t.TransactionStatus == TransactionStatus.Completed)
            .AsTracking()
            .ToListAsync(cancellationToken: cancellationToken);

        // Calculate today's revenue and bookings
        var todayRevenue = revenue.Sum(t => t.Amount);
        var todayBookings = booking.Count();

        // Create the response
        var response = new RevenueByAllOwnerTodayResponseDto
        {
            TodayRevenue = todayRevenue,
            TodayBookings = todayBookings
        };

        return Result<RevenueByAllOwnerTodayResponseDto>.Success(response);
    }
}