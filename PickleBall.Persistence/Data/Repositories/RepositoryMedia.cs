using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories
{
    internal sealed class RepositoryMedia : RepositoryBase<Media>, IRepositoryMedia
    {
        public RepositoryMedia(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Media>> GetMediasByUserId(Guid UserId, bool trackChanges, CancellationToken cancellationToken = default)
        => await GetEntitiesByConditionAsync(
               media => media.UserId == UserId && media.MediaUrl != null,
               trackChanges,
               cancellationToken
           );
    }
}
