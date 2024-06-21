using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories
{
    public interface IRepositoryWard : IRepositoryBase<Ward>
    {
        public Task<Ward?> GetUniqueWardByNameAsync(
                       string name,
                       bool trackChanges,
                       CancellationToken cancellationToken = default);
    }
}
