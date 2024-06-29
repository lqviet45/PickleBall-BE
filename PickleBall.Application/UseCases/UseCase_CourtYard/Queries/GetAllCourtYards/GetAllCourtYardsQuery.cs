using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.CourtYardDtos;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetAllCourtYards
{
    public class GetAllCourtYardsQuery : IRequest<Result<IEnumerable<CourtYardDto>>>
    {
        public bool TrackChanges { get; set; } = false;
    }
}
