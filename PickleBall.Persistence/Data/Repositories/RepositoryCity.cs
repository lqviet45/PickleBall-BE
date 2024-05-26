using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

public class RepositoryCity(ApplicationDbContext context)
    : RepositoryBase<City>(context),
        IRepositoryCity
{
    public async Task<IEnumerable<City>> GetAllCitiesAsync(
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<City> cities = await _context
            .Cities.AsNoTracking()
            .Where(c => !c.IsDeleted)
            .ToListAsync(cancellationToken);

        return cities;
    }

    public Task<City?> GetCityByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
