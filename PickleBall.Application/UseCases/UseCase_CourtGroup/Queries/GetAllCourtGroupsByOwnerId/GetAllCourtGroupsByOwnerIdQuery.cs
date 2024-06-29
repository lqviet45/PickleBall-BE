using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroupsByOwnerId;

public class GetAllCourtGroupsByOwnerIdQuery : IRequest<Result<IEnumerable<CourtGroupDto>>>
{
    public Guid OwnerId { get; set; }
    public bool TrackChanges { get; set; } = false;
    public CourtGroupParameters CourtGroupParameters { get; set; } = new();
}
