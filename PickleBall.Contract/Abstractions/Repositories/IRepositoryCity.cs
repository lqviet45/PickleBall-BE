using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryCity : IRepositoryBase<City>
{
    Task<IEnumerable<City>> GetAllCitiesAsync(CancellationToken cancellationToken = default);
    Task<City?> GetCityByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
