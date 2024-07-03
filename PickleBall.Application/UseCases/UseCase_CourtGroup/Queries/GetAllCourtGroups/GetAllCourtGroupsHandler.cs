using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroups;

internal sealed class GetAllCourtGroupsHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetAllCourtGroupsQuery, Result<PagedList<CourtGroupDto>>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<PagedList<CourtGroupDto>>> Handle(
        GetAllCourtGroupsQuery request,
        CancellationToken cancellationToken
    )
    {
        IEnumerable<CourtGroup> courtGroups =
            await _unitOfWork.RepositoryCourtGroup.GetAllCourtGroupsAsync(
                request.TrackChanges,
                request.CourtGroupParameters,
                cancellationToken
            );

        if (!courtGroups.Any())
            return Result.NotFound("Court Group is not found");

        var courtGroupDto = _mapper.Map<IEnumerable<CourtGroupDto>>(courtGroups);

        var pagedList = PagedList<CourtGroupDto>.ToPagedList(
            courtGroupDto,
            request.CourtGroupParameters.PageNumber,
            request.CourtGroupParameters.PageSize
        );

        return Result.Success(pagedList, "Court Group is found successfully");
    }
}
