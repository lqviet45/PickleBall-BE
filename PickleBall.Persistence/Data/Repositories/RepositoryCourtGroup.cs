using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;
using PickleBall.Persistence;
using PickleBall.Persistence.Data.Repositories;

namespace PickleBall.Infrastructure.Data.Repositories;

public class RepositoryCourtGroup(ApplicationDbContext context)
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

    public Task<CourtGroup?> GetCourtGroupByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default
    )
    {
        throw new NotImplementedException();
    }
}
