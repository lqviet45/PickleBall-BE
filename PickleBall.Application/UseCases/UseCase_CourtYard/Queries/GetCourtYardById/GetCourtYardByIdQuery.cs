using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;

namespace PickleBall.Application.UseCases.UseCase_CourtYard.Queries.GetCourtYardById
{
    public class GetCourtYardByIdQuery : IRequest<Result<CourtYardDto>>
    {
        public Guid CourtYardId { get; set; }
        public bool TrackChanges { get; set; } = false;
    }
}
