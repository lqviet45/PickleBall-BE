using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetCourtYardsByName
{
    public class GetCourtYardsByNameQuery : IRequest<Result<IEnumerable<CourtYardDto>>>
    {
        public string Name { get; set; } = string.Empty;
        public bool TrackChanges { get; set; } = false;
    }
}
