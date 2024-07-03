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
    public async Task<IEnumerable<CourtGroup>> GetAllCourtGroupsAsync(
        bool trackChanges,
        CourtGroupParameters courtGroupParameters,
        CancellationToken cancellationToken = default
    ) =>
        await GetAllAsync(
            trackChanges,
            cancellationToken,
            query =>
                query
                    .Include(c => c.Medias)
                    .Include(c => c.CourtYards)
                    .Include(c => c.Ward)
                    .ThenInclude(w => w.District)
                    .ThenInclude(d => d.City)
        // .Skip((courtGroupParameters.PageNumber - 1) * courtGroupParameters.PageSize)
        // .Take(courtGroupParameters.PageSize)
        );

    public async Task<CourtGroup?> GetCourtGroupByConditionAsync(
        Expression<Func<CourtGroup, bool>> conditions,
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) =>
        await GetEntityByConditionAsync(
            conditions,
            trackChanges,
            cancellationToken,
            query =>
                query
                    .Include(c => c.Medias)
                    .Include(c => c.CourtYards)
                    .Include(c => c.Ward)
                    .ThenInclude(w => w.District)
                    .ThenInclude(d => d.City)
        );

    public async Task<IEnumerable<CourtGroup>> GetAllCourtGroupsByConditionAsync(
        Expression<Func<CourtGroup, bool>> conditions,
        bool trackChanges,
        CourtGroupParameters courtGroupParameters,
        CancellationToken cancellationToken = default
    ) =>
        await GetEntitiesByConditionAsync(
            conditions,
            trackChanges,
            cancellationToken,
            query =>
                query
                    .Include(c => c.Medias)
                    .Include(c => c.CourtYards)
                    .Include(c => c.Ward)
                    .ThenInclude(w => w.District)
                    .ThenInclude(d => d.City)
        // .Skip((courtGroupParameters.PageNumber - 1) * courtGroupParameters.PageSize)
        // .Take(courtGroupParameters.PageSize)
        );
}
