using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroups;

internal sealed class GetAllCourtGroupsHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetAllCourtGroupsQuery, Result<IEnumerable<CourtGroupDto>>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<IEnumerable<CourtGroupDto>>> Handle(
        GetAllCourtGroupsQuery request,
        CancellationToken cancellationToken
    )
    {
        IEnumerable<CourtGroup> courtGroups =
            await _unitOfWork.RepositoryCourtGroup.GetCourtGroupsAsync(
                request.TrackChanges,
                cancellationToken
            );

        if (!courtGroups.Any())
            return Result.NotFound("Court Group is not found");

        var courtGroupDto = _mapper.Map<IEnumerable<CourtGroupDto>>(courtGroups);

        return Result.Success(courtGroupDto, "Court Group is found successfully");
    }
}
