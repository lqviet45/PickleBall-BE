using Ardalis.Result;
using MediatR;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Commands.DeleteCourtYard;

public class DeleteCourtYardCommand : IRequest<Result>
{
    public Guid Id { get; set; }
}
