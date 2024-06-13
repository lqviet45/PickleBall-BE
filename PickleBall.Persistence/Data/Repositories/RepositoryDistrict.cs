using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

internal sealed class RepositoryDistrict(ApplicationDbContext context)
    : RepositoryBase<District>(context),
        IRepositoryDistrict
{
    public async Task<District?> GetDistrictByIdAsync(
        int id,
        bool trackChanges,
        CancellationToken cancellationToken = default
    ) => await GetEntityByConditionAsync(c => c.Id == id, trackChanges, cancellationToken);
}
