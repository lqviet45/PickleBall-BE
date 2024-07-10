using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryTransaction : IRepositoryBase<Transaction>
{
    Task<IEnumerable<Transaction>> GetTransactionsByMonthAsync(
        Guid ownerId,
        int month,
        int year,
        bool trackChanges,
        CancellationToken cancellationToken
    );

    Task<IEnumerable<Transaction>> GetTransactionsByDayAsync(
        Guid ownerId,
        DateTime date,
        bool trackChanges,
        CancellationToken cancellationToken
    );
}
