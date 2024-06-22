using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_District.Queries.GetDistrictByName
{
    public class GetDistrictsByNameQuery : IRequest<Result<IEnumerable<DistrictDto>>>
    {
        public string Name { get; set; } = string.Empty;
        public bool TrackChanges { get; set; }
    }
}
