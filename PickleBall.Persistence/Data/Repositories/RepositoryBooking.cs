using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Data.Repositories;

internal sealed class RepositoryBooking(ApplicationDbContext context)
    : RepositoryBase<Booking>(context),
        IRepositoryBooking
{
    public async Task<IEnumerable<Booking>> GetAllBookingsByDateAsync(
        DateTime date,
        bool trackChanges,
        CancellationToken cancellationToken
    ) =>
        await GetEntitiesByConditionAsync(
            b => b.CreatedOnUtc.Date == date,
            trackChanges,
            cancellationToken
        );
}
