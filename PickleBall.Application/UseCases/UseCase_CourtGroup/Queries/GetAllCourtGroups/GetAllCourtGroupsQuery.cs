using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetAllCourtGroups;

public class GetAllCourtGroupsQuery : IRequest<Result<IEnumerable<CourtGroupDto>>>
{
    public bool TrackChanges { get; set; } = false;
    public CourtGroupParameters CourtGroupParameters { get; set; } = new();
}
