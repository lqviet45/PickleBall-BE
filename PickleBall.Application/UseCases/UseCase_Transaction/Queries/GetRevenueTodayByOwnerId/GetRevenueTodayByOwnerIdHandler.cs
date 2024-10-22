using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.TransactionDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueTodayByOwnerId;

public class GetRevenueTodayByOwnerIdHandler : IRequestHandler<GetRevenueTodayByOwnerIdQuery, Result<RevenueByOwnerTodayResponseDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<ApplicationUser> _userManager;

    public GetRevenueTodayByOwnerIdHandler(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public async Task<Result<RevenueByOwnerTodayResponseDto>> Handle(GetRevenueTodayByOwnerIdQuery request, CancellationToken cancellationToken)
    {
        // Retrieve owner
        var owner = await _userManager.Users
            .Where(u => u.Id == request.OwnerId)
            .FirstOrDefaultAsync(cancellationToken);
        
        if (owner == null)
        {
            return Result<RevenueByOwnerTodayResponseDto>.NotFound();
        }

        // Get current date for today’s calculations
        var today = DateTime.UtcNow;
        
        // Get today's bookings for the owner
        var todayBookings = await _unitOfWork.RepositoryBooking
            .GetQueryable()
            .Where(b => b.CourtGroup.UserId == request.OwnerId
                        && b.BookingStatus == BookingStatus.Completed
                        && b.CreatedOnUtc.Date == today.Date) // Only today’s bookings
            .AsTracking()
            .ToListAsync(cancellationToken: cancellationToken);

        // Get today's transactions for the owner
        var todayRevenueTransactions = await _unitOfWork.RepositoryTransaction
            .GetQueryable()
            .Where(t => t.UserId == request.OwnerId
                        && t.CreatedOnUtc.Date == today.Date // Only today’s transactions
                        && t.TransactionStatus == TransactionStatus.Completed)
            .AsTracking()
            .ToListAsync(cancellationToken: cancellationToken);

        // Calculate today's total revenue
        var todayRevenue = todayRevenueTransactions.Sum(t => t.Amount);
        var todayBookingCount = todayBookings.Count;

        // Get month revenue for the current month
        var monthRevenueTransactions = await _unitOfWork.RepositoryTransaction
            .GetQueryable()
            .Where(t => t.UserId == request.OwnerId
                        && t.CreatedOnUtc.Month == today.Month
                        && t.CreatedOnUtc.Year == today.Year
                        && t.TransactionStatus == TransactionStatus.Completed)
            .AsTracking()
            .ToListAsync(cancellationToken: cancellationToken);

        // Calculate total month revenue
        var monthRevenue = monthRevenueTransactions.Sum(t => t.Amount);

        // Create response DTO
        var revenueByOwnerTodayResponse = new RevenueByOwnerTodayResponseDto
        {
            MonthRevenue = monthRevenue,
            TodayRevenue = todayRevenue,
            TodayBookings = todayBookingCount
        };

        return Result<RevenueByOwnerTodayResponseDto>.Success(revenueByOwnerTodayResponse);
    }
}