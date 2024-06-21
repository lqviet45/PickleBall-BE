using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupsByNameAndCity
{
    public class GetCourtGroupsByNameAndCityQuery : IRequest<Result<IEnumerable<CourtGroupDto>>>
    {
        public string Name { get; init; }
        public string CityName { get; init; }

        public bool TrackChanges { get; init; } = false;
    }
}
