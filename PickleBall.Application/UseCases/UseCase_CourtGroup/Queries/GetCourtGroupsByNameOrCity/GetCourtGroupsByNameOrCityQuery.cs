using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupsByNameOrCity
{
    public class GetCourtGroupsByNameOrCityQuery : IRequest<Result<PagedList<CourtGroupDto>>>
    {
        public string Name { get; set; } = string.Empty;
        public string CityName { get; init; } = string.Empty;
        public bool TrackChanges { get; init; } = false;
        public CourtGroupParameters CourtGroupParameters { get; set; } = new();
    }
}
