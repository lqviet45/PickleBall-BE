using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_ApplicationUser.Queries.GetUserById;

internal sealed class GetUserByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetUserByIdQuery, Result<ApplicationUserDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

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

        return Result.Success(userDto, "User is found successfully");
    }
}
