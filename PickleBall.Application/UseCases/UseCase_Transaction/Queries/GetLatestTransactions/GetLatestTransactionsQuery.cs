using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetLatestTransactions
{
    public class GetLatestTransactionsQuery : IRequest<Result<PagedList<TransactionDto>>>
    {
        public bool TrackChanges { get; set; } = false;
        public TransactionParameters TransactionParameters { get; set; } = new();
    }
}
