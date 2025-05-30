using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroupsByOwnerId;

internal sealed class GetAllCourtGroupsByOwnerIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetAllCourtGroupsByOwnerIdQuery, Result<PagedList<CourtGroupDto>>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<PagedList<CourtGroupDto>>> Handle(
        GetAllCourtGroupsByOwnerIdQuery request,
        CancellationToken cancellationToken
    )
    {
        IEnumerable<CourtGroup> courtGroups =
            await _unitOfWork.RepositoryCourtGroup.GetAllCourtGroupsByConditionAsync(
                c => c.UserId == request.OwnerId,
                request.TrackChanges,
                request.CourtGroupParameters,
                cancellationToken
            );

        if (!courtGroups.Any())
            return Result.NotFound("CourtGroups are not found");

        var courtGroupDtos = _mapper.Map<IEnumerable<CourtGroupDto>>(courtGroups);

        var pagedList = PagedList<CourtGroupDto>.ToPagedList(
            courtGroupDtos,
            request.CourtGroupParameters.PageNumber,
            request.CourtGroupParameters.PageSize
        );

        return Result.Success(pagedList, "CourtGroups are found successfully");
    }
}
