using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories
{
    public interface IRepositorySlot : IRepositoryBase<Slot>
    {
        Task<IEnumerable<Slot>> GetSlotsByCourtYardIdAsync(
                       Guid courtYardId,
                       bool trackChanges,
                       CancellationToken cancellationToken = default
                   );
    }
}
