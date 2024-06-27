using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Commands.CreateCourtYardByCourtGroupId;

public class CreateCourtYardCommand : IRequest<Result<CourtYardDto>>
{
    public Guid CourtGroupId { get; set; }
    public string? Name { get; set; }
}
