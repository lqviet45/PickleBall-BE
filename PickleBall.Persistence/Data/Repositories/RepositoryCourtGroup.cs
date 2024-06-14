using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;
using PickleBall.Persistence;
using PickleBall.Persistence.Data.Repositories;

namespace PickleBall.Infrastructure.Data.Repositories;

internal sealed class RepositoryCourtGroup(ApplicationDbContext context)
    : RepositoryBase<CourtGroup>(context),
        IRepositoryCourtGroup
{
    public async Task<IEnumerable<CourtGroup>> GetCourtGroupsAsync(
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<CourtGroup> courtGroups = await _context
            .CourtGroups.AsNoTracking()
            .Where(c => !c.IsDeleted)
            .ToListAsync(cancellationToken);

        return courtGroups;
    }

    public async Task<CourtGroup?> GetCourtGroupByIdAsync(
        Guid id,
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) => await GetEntityByConditionAsync(c => c.Id == id, trackChanges, cancellationToken);

    public async Task<IEnumerable<CourtGroup>> GetCourtGroupsByManagerIdAsync(
        Guid managerId,
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) =>
        await GetEntitiesByConditionAsync(
            c => c.UserId == managerId,
            trackChanges,
            cancellationToken
        );
}
