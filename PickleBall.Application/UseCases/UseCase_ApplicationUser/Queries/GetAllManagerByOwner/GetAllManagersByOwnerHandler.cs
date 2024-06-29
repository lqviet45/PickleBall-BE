using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetAllManagerByOwner;

internal sealed class GetAllManagersByOwnerHandler(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    UserManager<ApplicationUser> userManager
) : IRequestHandler<GetAllManagersByOwnerQuery, Result<IEnumerable<ApplicationUserDto>>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public async Task<Result<IEnumerable<ApplicationUserDto>>> Handle(
        GetAllManagersByOwnerQuery request,
        CancellationToken cancellationToken
    )
    {
        var owner = await _unitOfWork.RepositoryApplicationUser.GetUserByConditionAsync(
            x => x.Id == request.Id,
            false,
            cancellationToken
        );

        if (owner is null)
            return Result.NotFound("Owner not found");

        var roles = await _userManager.GetRolesAsync(owner);
        if (roles.Count == 0 || roles[0] != Role.Owner.ToString())
            return Result.Error("Owner not found");

        var managers = await _unitOfWork.RepositoryApplicationUser.GetAllUsersByConditionAsync(
            x => x.SupervisorId == request.Id,
            false,
            cancellationToken
        );

        var managerDtos = _mapper.Map<IEnumerable<ApplicationUserDto>>(managers);

        return Result.Success(managerDtos, "Managers are found successfully");
    }
}
