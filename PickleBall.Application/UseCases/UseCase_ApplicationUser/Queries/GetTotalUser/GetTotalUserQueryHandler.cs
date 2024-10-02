using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetTotalUser;

public class GetTotalUserQueryHandler : IRequestHandler<GetTotalUserQuery, Result<int>>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<ApplicationRole> _roleManager;

    public GetTotalUserQueryHandler(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task<Result<int>> Handle(GetTotalUserQuery request, CancellationToken cancellationToken)
    {
        var users = await _userManager.Users
            .AsNoTracking()
            .ToListAsync(cancellationToken: cancellationToken);
        
        var roles = await _roleManager.Roles
            .FirstOrDefaultAsync(r => r.Name == Role.Customer.ToString(), cancellationToken: cancellationToken);
        
        var count = 0;
        if (roles is null) return Result<int>.Success(count);
        
        foreach (var user in users)
        {
            if (await _userManager.IsInRoleAsync(user, roles.Name!))
            {
                count++;
            }
        }

        return Result<int>.Success(count);
    }
}