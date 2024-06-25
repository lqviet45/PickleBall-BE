using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.CreateCourtGroup
{
    public class CreateCourtGroupCommand : IRequest<Result<CourtGroupDto>>
    {
        public Guid UserId { get; set; }
        public string WardName { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int MinSlots { get; set; }
        public int MaxSlots { get; set; }
    }
}
