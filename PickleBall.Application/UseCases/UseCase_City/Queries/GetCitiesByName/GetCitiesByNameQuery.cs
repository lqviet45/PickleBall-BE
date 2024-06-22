using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_City.Queries.GetCitiesByName
{
    public class GetCitiesByNameQuery : IRequest<Result<IEnumerable<CityDto>>>
    {
        public string Name { get; set; }
        public bool TrackChanges { get; set; } = false;
    }
}
