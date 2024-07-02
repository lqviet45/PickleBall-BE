using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Persistence.Data.Repositories;

public class RepositoryTransaction(ApplicationDbContext context)
    : RepositoryBase<Transaction>(context),
        IRepositoryTransaction
{
    public async Task<IEnumerable<Transaction>> GetTransactionsByMonthAsync(
        Guid ownerId,
        int month,
        int year,
        bool trackChanges,
        CancellationToken cancellationToken
    ) =>
        await GetEntitiesByConditionAsync(
            t =>
                t.UserId == ownerId
                && t.CreatedOnUtc.Month == month
                && t.CreatedOnUtc.Year == year
                && t.TransactionStatus == TransactionStatus.Completed
                && t.Description == "Booking Income",
            trackChanges,
            cancellationToken
        );
}
