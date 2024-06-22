using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_Slot.Queries.GetSlotById
{
    public class GetSlotByIdQuery : IRequest<Result<SlotDto>>
    {
        public Guid Id { get; set; }
        public bool TrackChanges { get; set; } = false;
    }
}
