using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs.TransactionDtos;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetRevenueByCourtGroupId
{
    public class GetRevenueByCourtGroupIdQuery : IRequest<Result<RevenueResponseDto>>
    {
        public Guid CourtGroupId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public bool TrackChanges { get; set; } = false;
    }
}
