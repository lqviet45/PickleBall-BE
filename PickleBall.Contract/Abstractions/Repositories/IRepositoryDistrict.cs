using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryDistrict : IRepositoryBase<District>
{
    Task<District?> GetDistrictByIdAsync(
        int id,
        bool trackChanges,
        CancellationToken cancellationToken = default
    );
}
