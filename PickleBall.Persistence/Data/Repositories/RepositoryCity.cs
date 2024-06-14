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
    ) => await GetEntitiesByConditionAsync(c => !c.IsDeleted, trackChanges, cancellationToken);

    public Task<City?> GetCityByIdAsync(
        Guid id,
        bool trackChanges,
        CancellationToken cancellationToken = default
    )
    {
        throw new NotImplementedException();
    }
}
