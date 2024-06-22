using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories
{
    public interface IRepositoryMedia : IRepositoryBase<Media>
    {
        Task<IEnumerable<Media>> GetMediasByUserId(
            Guid UserId,
            bool trackChanges,
            CancellationToken cancellationToken = default);
    }
}
