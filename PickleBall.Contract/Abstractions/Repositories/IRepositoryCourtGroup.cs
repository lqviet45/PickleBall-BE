using PickleBall.Domain.Entities;

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

    Task<IEnumerable<CourtGroup>> GetCourtGroupsByManagerIdAsync(
        Guid managerId,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );
}
