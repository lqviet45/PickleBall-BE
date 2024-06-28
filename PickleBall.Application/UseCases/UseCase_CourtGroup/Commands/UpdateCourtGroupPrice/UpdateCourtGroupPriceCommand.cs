using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.UpdateCourtGroupPrice;

public class UpdateCourtGroupPriceCommand : IRequest<Result<CourtGroupDto>>
{
    public Guid Id { get; set; }
    public decimal Price { get; set; }
}
