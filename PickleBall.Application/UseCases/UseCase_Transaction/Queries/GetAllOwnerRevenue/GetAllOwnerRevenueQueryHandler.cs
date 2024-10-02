using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllOwnerRevenue;

public class GetAllOwnerRevenueQueryHandler : IRequestHandler<GetAllOwnerRevenueQuery, Result<decimal>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<ApplicationUser> _userManager;

    public GetAllOwnerRevenueQueryHandler(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public async Task<Result<decimal>> Handle(GetAllOwnerRevenueQuery request, CancellationToken cancellationToken)
    {
        var users = await _unitOfWork.RepositoryApplicationUser
            .GetQueryable()
            .ToListAsync(cancellationToken: cancellationToken);  // Fetch users first

        var owners = new List<Guid>();

        foreach (var user in users)
        {
            if (await _userManager.IsInRoleAsync(user, Role.Owner.ToString()))
            {
                owners.Add(user.Id);
            }
        }

        var revenue = await _unitOfWork.RepositoryTransaction
            .GetQueryable()
            .Where(t => owners.Contains(t.UserId)
                        && t.CreatedOnUtc.Month == request.Month
                        && t.CreatedOnUtc.Year == request.Year
                        && t.TransactionStatus == TransactionStatus.Completed)
            .AsTracking()
            .SumAsync(t => t.Amount, cancellationToken);
        
        return Result<decimal>.Success(revenue);
    }
}