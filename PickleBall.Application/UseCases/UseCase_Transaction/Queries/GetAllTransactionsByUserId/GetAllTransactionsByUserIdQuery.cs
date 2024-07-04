using Ardalis.Result;
using MediatR;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Paging;

namespace PickleBall.Application.UseCases.UseCase_Transaction.Queries.GetAllTransactionsByUserId
{
    public class GetAllTransactionsByUserIdQuery : IRequest<Result<PagedList<TransactionDto>>>
    {
        public Guid UserId { get; set; }
        public bool TrackChanges { get; set; } = false;
        public TransactionParameters TransactionParameters { get; set; } = new();
    }
}
