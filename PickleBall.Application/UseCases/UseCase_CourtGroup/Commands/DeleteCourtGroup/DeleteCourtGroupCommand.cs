using Ardalis.Result;
using MediatR;

namespace PickleBall.Application.UseCases.UseCase_CourtGroup.Commands.DeleteCourtGroup
{
    public class DeleteCourtGroupCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
    }
}
