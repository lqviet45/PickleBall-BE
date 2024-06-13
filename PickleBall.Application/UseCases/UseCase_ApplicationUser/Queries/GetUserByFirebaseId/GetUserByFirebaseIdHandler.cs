using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserByFirebaseId;

internal sealed class GetUserByFirebaseIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetUserByFirebaseIdQuery, Result<ApplicationUserDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<ApplicationUserDto>> Handle(
        GetUserByFirebaseIdQuery request,
        CancellationToken cancellationToken
    )
    {
        ApplicationUser? user =
            await _unitOfWork.RepositoryApplicationUser.GetUserByFirebaseIdAsync(
                request.FirebaseId ?? string.Empty,
                cancellationToken
            );

        if (user is null)
            return Result.NotFound("User is not found");

        ApplicationUserDto userDto = _mapper.Map<ApplicationUserDto>(user);

        return Result.Success(userDto, "User is found successfully");
    }
}
