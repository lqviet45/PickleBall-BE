using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupsWithRevenueByOwnerId
{
    public class GetCourtGroupsWithRevenueByOwnerIdQuery : IRequest<Result<PagedList<CourtGroupDto>>>
    {
        public Guid OwnerId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public bool TrackChanges { get; set; } = false;
        public CourtGroupParameters CourtGroupParameters { get; set; } = new();
    }
}
