using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;
using PickleBall.Persistence;
using PickleBall.Persistence.Data.Repositories;
using System.Linq.Expressions;

namespace PickleBall.Infrastructure.Data.Repositories;

internal sealed class RepositoryCourtGroup(ApplicationDbContext context)
    : RepositoryBase<CourtGroup>(context),
        IRepositoryCourtGroup
{
    public async Task<IEnumerable<CourtGroup>> GetCourtGroupsAsync(
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) => await GetEntitiesByConditionAsync(c => !c.IsDeleted, trackChanges, cancellationToken);

    public async Task<CourtGroup?> GetCourtGroupByIdAsync(
        Guid id,
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) => await GetEntityByConditionAsync(c => c.Id == id, trackChanges, cancellationToken);

    public async Task<IEnumerable<CourtGroup>> GetCourtGroupsByOwnerIdAsync(
        Guid ownerId,
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) =>
        await GetEntitiesByConditionAsync(
            c => c.UserId == ownerId,
            trackChanges,
            cancellationToken
        );

    public async Task<IEnumerable<CourtGroup>> GetCourtGroupsByConditionsAsync(
        Expression<Func<CourtGroup, bool>> conditions,
        bool trackChanges,
        CancellationToken cancellationToken = default)
        => trackChanges
            ? await _context.CourtGroups
                .Include(c => c.Ward)
                .ThenInclude(w => w.District)
                .ThenInclude(d => d.City)
                .Where(conditions)
                .IgnoreQueryFilters()
                .ToListAsync(cancellationToken)
            : await _context.CourtGroups
                .Include(c => c.Ward)
                .ThenInclude(w => w.District)
                .ThenInclude(d => d.City)
                .AsNoTracking().Where(conditions)
                .IgnoreQueryFilters()
                .ToListAsync(cancellationToken);
}
