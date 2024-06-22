using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

internal sealed class RepositoryCity(ApplicationDbContext context)
    : RepositoryBase<City>(context),
        IRepositoryCity
{
    public async Task<IEnumerable<City>> GetAllCitiesAsync(
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) =>
        trackChanges
            ? await _context.Cities.Include(city => city.Districts).ToListAsync(cancellationToken)
            : await _context
                .Cities.Include(city => city.Districts)
                .AsNoTracking()
                .ToListAsync(cancellationToken);

    public async Task<IEnumerable<City>> GetCitiesByNameAsync(
        string name,
        bool trackChanges,
        CancellationToken cancellationToken = default
    )
    => await GetEntitiesByConditionAsync(
            city => city.Name != null && city.Name.Contains(name),
            trackChanges,
            cancellationToken);
}
