using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_District.Queries.GetAllDistrict
{
    public class GetAllDistrictQuery : IRequest<Result<IEnumerable<DistrictDto>>>
    {
        public bool TrackChanges { get; set; } = false;
    }
}
