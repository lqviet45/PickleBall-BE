using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.CourtYardDtos;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetAllByCourtGroupId;

public class GetAllCourtYardsByCourtGroupIdQuery : IRequest<Result<IEnumerable<CourtYardDto>>>
{
    public Guid CourtGroupId { get; set; }
    public bool TrackChanges { get; set; } = false;
    public CourtYardParameters CourtYardParameters { get; set; } = new();
}
