using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetAllByCourtGroupId;

internal sealed class GetAllByCourtGroupIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetAllCourtYardsByCourtGroupIdQuery, Result<IEnumerable<CourtYardDto>>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result<IEnumerable<CourtYardDto>>> Handle(
        GetAllCourtYardsByCourtGroupIdQuery request,
        CancellationToken cancellationToken
    )
    {
        IEnumerable<CourtYard> courtYards =
            await _unitOfWork.RepositoryCourtYard.GetAllByCourtGroupIdAsync(
                request.CourtGroupId,
                request.TrackChanges,
                cancellationToken
            );


        IEnumerable<CourtYardDto> courtYardDtos = _mapper.Map<IEnumerable<CourtYardDto>>(
            courtYards
        );

        if (!courtYards.Any())
            return Result.Success(courtYardDtos, "There are no courtyards in this courtgroup");

        return Result.Success(courtYardDtos, "Court Yard is found successfully");
    }
}
