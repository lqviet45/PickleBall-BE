using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroupsByManagerId;

public class GetAllCourtGroupsByManagerIdQuery : IRequest<Result<IEnumerable<CourtGroupDto>>>
{
    public Guid ManagerId { get; set; }
    public bool TrackChanges { get; set; } = false;
}
