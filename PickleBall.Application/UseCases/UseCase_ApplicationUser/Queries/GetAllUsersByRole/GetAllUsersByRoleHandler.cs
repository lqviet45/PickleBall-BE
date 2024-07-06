using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetAllUsersByRole;

internal sealed class GetAllUsersByRoleHandler(
    IMapper mapper,
    UserManager<ApplicationUser> userManager,
    RoleManager<ApplicationRole> roleManager
) : IRequestHandler<GetAllUsersByRoleQuery, Result<IEnumerable<ApplicationUserDto>>>
{
    private readonly IMapper _mapper = mapper;
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    private readonly RoleManager<ApplicationRole> _roleManager = roleManager;

    public async Task<Result<IEnumerable<ApplicationUserDto>>> Handle(
        GetAllUsersByRoleQuery request,
        CancellationToken cancellationToken
    )
    {
        string roleName = request.Role.ToString();
        var role = await _roleManager.FindByNameAsync(roleName);

        if (role == null)
            return Result.NotFound($"Role {roleName} not found");

        var users = await _userManager.GetUsersInRoleAsync(roleName);

        if (!users.Any())
            return Result.NotFound($"Users with role {roleName} not found");

        var usersDto = _mapper.Map<IEnumerable<ApplicationUserDto>>(users);

        return Result.Success(usersDto, $"Users with role {roleName} found successfully");
    }
}
