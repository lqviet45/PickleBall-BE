using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotsByName
{
    public class GetSlotsByNameQuery : IRequest<Result<IEnumerable<SlotDto>>>
    {
        public string Name { get; set; } = string.Empty;
        public bool TrackChanges { get; set; } = false;
    }
}
