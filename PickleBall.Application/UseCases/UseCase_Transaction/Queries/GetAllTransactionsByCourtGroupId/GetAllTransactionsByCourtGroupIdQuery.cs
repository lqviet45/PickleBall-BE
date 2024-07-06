using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllTransactionsByCourtGroupId
{
    public class GetAllTransactionsByCourtGroupIdQuery : IRequest<Result<PagedList<TransactionDto>>>
    {
        public Guid CourtGroupId { get; set; }

        public bool TrackChanges { get; set; } = false;

        public TransactionParameters TransactionParameters { get; set; } = new();
    }
}
