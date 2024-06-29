using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.DTOs.CourtYardDtos;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetCourtYardsByName
{
    internal sealed class GetCourtYardsByNameHandler
        : IRequestHandler<GetCourtYardsByNameQuery, Result<IEnumerable<CourtYardDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCourtYardsByNameHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<CourtYardDto>>> Handle(
            GetCourtYardsByNameQuery request,
            CancellationToken cancellationToken
        )
        {
            var courtYards = await _unitOfWork.RepositoryCourtYard.GetEntitiesByConditionAsync(
                c => c.Name != null && c.Name.Contains(request.Name),
                request.TrackChanges,
                cancellationToken
            );

            if (!courtYards.Any())
                return Result.NotFound("Court Yards are not found");

            var courtYardDtos = _mapper.Map<IEnumerable<CourtYardDto>>(courtYards);

            return Result.Success(courtYardDtos, "Court Yards are found successfully");
        }
    }
}
