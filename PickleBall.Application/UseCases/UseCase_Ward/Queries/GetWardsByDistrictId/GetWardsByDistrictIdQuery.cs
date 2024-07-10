using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Ward.Queries.GetWardsByDistrictId
{
    public class GetWardsByDistrictIdQuery : IRequest<Result<PagedList<WardDto>>>
    {
        public int DistrictId { get; set; }
        public bool TrackChanges { get; set; } = false;
        public WardParameters WardParameters { get; set; } = new();
    }
}
