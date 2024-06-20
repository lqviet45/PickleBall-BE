using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories
{
    internal sealed class RepositorySlot : RepositoryBase<Slot>, IRepositorySlot
    {
        public RepositorySlot(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Slot>> GetSlotsByCourtYardIdAsync(
            Guid courtYardId,
            bool trackChanges,
            CancellationToken cancellationToken = default) 
            => await GetEntitiesByConditionAsync(s => s.CourtYardId == courtYardId, trackChanges, cancellationToken);
    }
}
