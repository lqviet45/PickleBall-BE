using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

internal sealed class RepositoryCourtYard(ApplicationDbContext context)
    : RepositoryBase<CourtYard>(context),
        IRepositoryCourtYard
{
    public async Task<IEnumerable<CourtYard>> GetAllByCourtGroupIdAsync(
        Guid courtGroupId,
        bool trackChanges,
        CancellationToken cancellationToken
    ) =>
        await GetEntitiesByConditionAsync(
            c => c.CourtGroupId == courtGroupId && !c.IsDeleted,
            trackChanges,
            cancellationToken
        );

    public async Task<CourtYard?> GetCourtYardByIdAsync(
        Guid id,
        bool trackChanges,
        CancellationToken cancellationToken
    ) => await GetEntityByConditionAsync(
            yard => yard.Id == id,
            trackChanges,
            cancellationToken);
}
