using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroupsByOwnerId;

public class GetAllCourtGroupsByOwnerIdQuery : IRequest<Result<IEnumerable<CourtGroupDto>>>
{
    public Guid OwnerId { get; set; }
    public bool TrackChanges { get; set; } = false;
}
