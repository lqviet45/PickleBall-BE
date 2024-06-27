using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Commands.UpdateCourtYard;

public class UpdateCourtYardCommand : IRequest<Result<CourtYardDto>>
{
    public Guid CourtYardId { get; set; }
    public string? Name { get; set; }
    public CourtYardStatus CourtYardStatus { get; set; }
}
