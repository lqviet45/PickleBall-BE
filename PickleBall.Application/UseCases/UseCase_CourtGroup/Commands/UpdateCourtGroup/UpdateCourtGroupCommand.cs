using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.CourtGroupsDtos;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.UpdateCourtGroup;

public class UpdateCourtGroupCommand : IRequest<Result<CourtGroupDto>>
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public int MinSlots { get; set; }
    public int MaxSlots { get; set; }
}
