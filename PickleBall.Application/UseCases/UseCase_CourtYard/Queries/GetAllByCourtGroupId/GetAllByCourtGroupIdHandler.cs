using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.CourtYardDtos;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetAllByCourtGroupId;

internal sealed class GetAllByCourtGroupIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetAllCourtYardsByCourtGroupIdQuery, Result<PagedList<CourtYardDto>>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<PagedList<CourtYardDto>>> Handle(
        GetAllCourtYardsByCourtGroupIdQuery request,
        CancellationToken cancellationToken
    )
    {
        IEnumerable<CourtYard> courtYards =
            await _unitOfWork.RepositoryCourtYard.GetAllByConditionAsync(
                c => c.CourtGroupId == request.CourtGroupId,
                request.TrackChanges,
                request.CourtYardParameters,
                cancellationToken
            );

        courtYards = courtYards.OrderBy(c => c.Name);

        IEnumerable<CourtYardDto> courtYardDtos = _mapper.Map<IEnumerable<CourtYardDto>>(
            courtYards
        );

        var pagedList = PagedList<CourtYardDto>.ToPagedList(
            courtYardDtos,
            request.CourtYardParameters.PageNumber,
            request.CourtYardParameters.PageSize
        );

        return Result.Success(pagedList, "Court Yard is found successfully");
    }
}
