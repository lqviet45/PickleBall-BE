using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;
using PickleBall.Persistence;
using PickleBall.Persistence.Data.Repositories;

namespace PickleBall.Infrastructure.Data.Repositories;

internal sealed class RepositoryCourtGroup(ApplicationDbContext context)
    : RepositoryBase<CourtGroup>(context),
        IRepositoryCourtGroup
{
    public async Task<IEnumerable<CourtGroup>> GetCourtGroupsAsync(
        bool trackChanges,
        CourtGroupParameters courtGroupParameters,
        CancellationToken cancellationToken = default
    ) =>
        trackChanges
            ? await _context
                .CourtGroups.Include(c => c.Medias)
                .Include(c => c.CourtYards)
                .Include(c => c.Ward)
                .ThenInclude(w => w.District)
                .ThenInclude(d => d.City)
                .Skip((courtGroupParameters.PageNumber - 1) * courtGroupParameters.PageSize)
                .Take(courtGroupParameters.PageSize)
                .ToListAsync(cancellationToken)
            : await _context
                .CourtGroups.Include(c => c.Medias)
                .Include(c => c.CourtYards)
                .Include(c => c.Ward)
                .ThenInclude(w => w.District)
                .ThenInclude(d => d.City)
                .Skip((courtGroupParameters.PageNumber - 1) * courtGroupParameters.PageSize)
                .Take(courtGroupParameters.PageSize)
                .AsNoTracking()
                .ToListAsync(cancellationToken);

    public async Task<CourtGroup?> GetCourtGroupByIdAsync(
        Guid id,
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) =>
        trackChanges
            ? await _context
                .CourtGroups.Include(c => c.User)
                .ThenInclude(u => u.Medias)
                .AsSplitQuery()
                .Include(c => c.Medias)
                .Include(c => c.CourtYards)
                .AsSplitQuery()
                .Include(c => c.Ward)
                .ThenInclude(w => w.District)
                .ThenInclude(d => d.City)
                .FirstOrDefaultAsync(c => c.Id == id, cancellationToken)
            : await _context
                .CourtGroups.Include(c => c.User)
                .ThenInclude(u => u.Medias)
                .AsSplitQuery()
                .Include(c => c.Medias)
                .Include(c => c.CourtYards)
                .AsSplitQuery()
                .Include(c => c.Ward)
                .ThenInclude(w => w.District)
                .ThenInclude(d => d.City)
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);

    public async Task<IEnumerable<CourtGroup>> GetCourtGroupsByOwnerIdAsync(
        Guid ownerId,
        bool trackChanges,
        CourtGroupParameters courtGroupParameters,
        CancellationToken cancellationToken = default
    ) =>
        trackChanges
            ? await _context
                .CourtGroups.Where(c => c.UserId == ownerId)
                .Include(c => c.Medias)
                .Include(c => c.CourtYards)
                .Include(c => c.Ward)
                .ThenInclude(w => w.District)
                .ThenInclude(d => d.City)
                .Skip((courtGroupParameters.PageNumber - 1) * courtGroupParameters.PageSize)
                .Take(courtGroupParameters.PageSize)
                .ToListAsync(cancellationToken)
            : await _context
                .CourtGroups.Where(c => c.UserId == ownerId)
                .Include(c => c.Medias)
                .Include(c => c.CourtYards)
                .Include(c => c.Ward)
                .ThenInclude(w => w.District)
                .ThenInclude(d => d.City)
                .Skip((courtGroupParameters.PageNumber - 1) * courtGroupParameters.PageSize)
                .Take(courtGroupParameters.PageSize)
                .AsNoTracking()
                .ToListAsync(cancellationToken);

    public async Task<IEnumerable<CourtGroup>> GetCourtGroupsByConditionsAsync(
        Expression<Func<CourtGroup, bool>> conditions,
        bool trackChanges,
        CourtGroupParameters courtGroupParameters,
        CancellationToken cancellationToken = default
    ) =>
        trackChanges
            ? await _context
                .CourtGroups.Include(c => c.Medias)
                .Include(c => c.Ward)
                .ThenInclude(w => w.District)
                .ThenInclude(d => d.City)
                .Where(conditions)
                .Skip((courtGroupParameters.PageNumber - 1) * courtGroupParameters.PageSize)
                .Take(courtGroupParameters.PageSize)
                .ToListAsync(cancellationToken)
            : await _context
                .CourtGroups.Include(c => c.Medias)
                .Include(c => c.Ward)
                .ThenInclude(w => w.District)
                .ThenInclude(d => d.City)
                .Where(conditions)
                .Skip((courtGroupParameters.PageNumber - 1) * courtGroupParameters.PageSize)
                .Take(courtGroupParameters.PageSize)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
}
