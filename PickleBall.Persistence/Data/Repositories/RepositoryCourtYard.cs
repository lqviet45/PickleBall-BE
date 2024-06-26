using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Persistence.Data.Repositories;

internal sealed class RepositoryCourtYard(ApplicationDbContext context)
    : RepositoryBase<CourtYard>(context),
        IRepositoryCourtYard
{
    public async Task<IEnumerable<CourtYard>> GetAllByCourtGroupIdAsync(
        Guid courtGroupId,
        bool trackChanges,
        CourtYardParameters courtYardParameters,
        CancellationToken cancellationToken
    ) =>
        // await GetEntitiesByConditionAsync(
        //     c => c.CourtGroupId == courtGroupId && !c.IsDeleted,
        //     trackChanges,
        //     cancellationToken
        // );
        trackChanges
            ? await _context
                .CourtYards.Where(c => c.CourtGroupId == courtGroupId)
                .Skip((courtYardParameters.PageNumber - 1) * courtYardParameters.PageSize)
                .Take(courtYardParameters.PageSize)
                .ToListAsync(cancellationToken)
            : await _context
                .CourtYards.Where(c => c.CourtGroupId == courtGroupId)
                .Skip((courtYardParameters.PageNumber - 1) * courtYardParameters.PageSize)
                .Take(courtYardParameters.PageSize)
                .AsNoTracking()
                .ToListAsync(cancellationToken);

    public async Task<CourtYard?> GetCourtYardByIdAsync(
        Guid id,
        bool trackChanges,
        CancellationToken cancellationToken
    ) => await GetEntityByConditionAsync(yard => yard.Id == id, trackChanges, cancellationToken);
}
