using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCities;

public class GetAllCitiesQuery : IRequest<Result<IEnumerable<CityDto>>>
{
    public bool TrackChanges { get; set; } = false;
}
