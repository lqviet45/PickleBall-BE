using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Persistence.Data.Repositories;

internal sealed class RepositoryCourtYard(ApplicationDbContext context)
    : RepositoryBase<CourtYard>(context),
        IRepositoryCourtYard
{
    public async Task<IEnumerable<CourtYard>> GetAllByConditionAsync(
        Expression<Func<CourtYard, bool>> conditions,
        bool trackChanges,
        CourtYardParameters courtYardParameters,
        CancellationToken cancellationToken
    ) =>
        await GetEntitiesByConditionAsync(
            conditions,
            trackChanges,
            cancellationToken,
            query => query.Include(c => c.Slots.Take(5))
        );

    public async Task<CourtYard?> GetCourtYardByIdAsync(
        Guid id,
        bool trackChanges,
        CancellationToken cancellationToken
    ) => await GetEntityByConditionAsync(yard => yard.Id == id, trackChanges, cancellationToken);
}
