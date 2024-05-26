using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryCourtGroup : IRepositoryBase<CourtGroup>
{
    Task<IEnumerable<CourtGroup>> GetCourtGroupsAsync(
        CancellationToken cancellationToken = default
    );
    Task<CourtGroup?> GetCourtGroupByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default
    );
}
