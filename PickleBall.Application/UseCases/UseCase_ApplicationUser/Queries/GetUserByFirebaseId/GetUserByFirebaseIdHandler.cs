using Ardalis.Result;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.Enum;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserByFirebaseId;

internal sealed class GetUserByFirebaseIdHandler(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    UserManager<ApplicationUser> userManager
) : IRequestHandler<GetUserByFirebaseIdQuery, Result<ApplicationUserDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public async Task<Result<ApplicationUserDto>> Handle(
        GetUserByFirebaseIdQuery request,
        CancellationToken cancellationToken
    )
    {
        ApplicationUser? user = await _unitOfWork.RepositoryApplicationUser.GetUserByConditionAsync(
            u => u.IdentityId == request.FirebaseId,
            false,
            cancellationToken
        );

        if (user is null)
            return Result.NotFound("User is not found");

        ApplicationUserDto userDto = _mapper.Map<ApplicationUserDto>(user);
        userDto.Role = (Role)Enum.Parse(typeof(Role), (await _userManager.GetRolesAsync(user))[0]);

        return Result.Success(userDto, "User is found successfully");
    }
}
