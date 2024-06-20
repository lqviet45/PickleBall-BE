using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotsByCourtYardId
{
    public class GetSlotsByCourtYardIdQuery : IRequest<Result<IEnumerable<SlotDto>>>
    {
        public Guid CourtYardId { get; init; }
        public bool TrackChanges { get; init; } = false;
    }
}
