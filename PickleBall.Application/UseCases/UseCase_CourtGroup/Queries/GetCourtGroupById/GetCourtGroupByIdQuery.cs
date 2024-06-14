using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Queries.GetCourtGroupById;

public class GetCourtGroupByIdQuery : IRequest<Result<CourtGroupDto>>
{
    public Guid Id { get; set; }
    public bool TrackChanges { get; set; } = false;
}
