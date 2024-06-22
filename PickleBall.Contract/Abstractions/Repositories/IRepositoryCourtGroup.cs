using PickleBall.Domain.Entities;
using System.Linq.Expressions;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryCourtGroup : IRepositoryBase<CourtGroup>
{
    Task<IEnumerable<CourtGroup>> GetCourtGroupsAsync(
        bool trackChanges,
        CancellationToken cancellationToken = default
    );

    Task<CourtGroup?> GetCourtGroupByIdAsync(
        Guid id,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );

    Task<IEnumerable<CourtGroup>> GetCourtGroupsByOwnerIdAsync(
        Guid ownerId,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );

    Task<IEnumerable<CourtGroup>> GetCourtGroupsByConditionsAsync(
        Expression<Func<CourtGroup, bool>> conditions,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );
}
