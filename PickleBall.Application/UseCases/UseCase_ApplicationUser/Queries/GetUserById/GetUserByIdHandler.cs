using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserById;

internal sealed class GetUserByIdHandler(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    UserManager<ApplicationUser> userManager
) : IRequestHandler<GetUserByIdQuery, Result<ApplicationUserDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public async Task<Result<ApplicationUserDto>> Handle(
        GetUserByIdQuery request,
        CancellationToken cancellationToken
    )
    {
        var user = await _unitOfWork.RepositoryApplicationUser.GetUserByIdAsync(
            request.Id,
            request.TrackChanges,
            cancellationToken
        );

        if (user is null)
            return Result.NotFound("User is not found");

        var userDto = _mapper.Map<ApplicationUserDto>(user);

        var roles = await _userManager.GetRolesAsync(user);
        if (roles.Count == 0)
            return Result.Error();

        userDto.Role = (Role)Enum.Parse(typeof(Role), roles[0]);

        return Result.Success(userDto, "User is found successfully");
    }
}
