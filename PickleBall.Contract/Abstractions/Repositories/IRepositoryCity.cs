using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryCity : IRepositoryBase<City>
{
    Task<IEnumerable<City>> GetAllCitiesAsync(
        bool trackChanges,
        CancellationToken cancellationToken = default
    );

    Task<IEnumerable<City>> GetCitiesByNameAsync(
        string name,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );
}
