using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupById;

internal sealed class GetCourtGroupByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetCourtGroupByIdQuery, Result<CourtGroupDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<CourtGroupDto>> Handle(
        GetCourtGroupByIdQuery request,
        CancellationToken cancellationToken
    )
    {
        var courtGroups = await _unitOfWork.RepositoryCourtGroup.GetCourtGroupByConditionAsync(
            c => c.Id == request.Id,
            request.TrackChanges,
            cancellationToken
        );

        if (courtGroups is null)
            return Result.NotFound("CourtGroup is not found");

        var courtGroupDto = _mapper.Map<CourtGroupDto>(courtGroups);

        return Result.Success(courtGroupDto, "CourtGroup is found successfully");
    }
}
