using Ardalis.Result;
using AutoMapper;
using MediatR;
using PickleBall.Application.Abstractions;
using PickleBall.Domain.DTOs.CourtYardDtos;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetAllCourtYards
{
    internal sealed class GetAllCourtYardsHandler
        : IRequestHandler<GetAllCourtYardsQuery, Result<IEnumerable<CourtYardDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllCourtYardsHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<CourtYardDto>>> Handle(
            GetAllCourtYardsQuery request,
            CancellationToken cancellationToken
        )
        {
            var courtYards = await _unitOfWork.RepositoryCourtYard.GetAllAsync(
                request.TrackChanges,
                cancellationToken
            );

            if (!courtYards.Any())
                return Result.NotFound("Court yards are not found");

            var courtYardDtos = _mapper.Map<IEnumerable<CourtYardDto>>(courtYards);
            return Result.Success(courtYardDtos, "Court yards are found successfully!");
        }
    }
}
