using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroupsByManagerId;

internal sealed class GetAllCourtGroupsByManagerIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetAllCourtGroupsByManagerIdQuery, Result<IEnumerable<CourtGroupDto>>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<IEnumerable<CourtGroupDto>>> Handle(
        GetAllCourtGroupsByManagerIdQuery request,
        CancellationToken cancellationToken
    )
    {
        IEnumerable<CourtGroup> courtGroups =
            await _unitOfWork.RepositoryCourtGroup.GetCourtGroupsByManagerIdAsync(
                request.ManagerId,
                request.TrackChanges,
                cancellationToken
            );

        if (!courtGroups.Any())
            return Result.NotFound("CourtGroups are not found");

        var courtGroupDtos = _mapper.Map<IEnumerable<CourtGroupDto>>(courtGroups);

        return Result.Success(courtGroupDtos, "CourtGroups are found successfully");
    }
}
