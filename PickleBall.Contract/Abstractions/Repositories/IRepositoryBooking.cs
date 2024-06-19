using PickleBall.Domain.Entities;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryBooking : IRepositoryBase<Booking>
{
    Task<IEnumerable<Booking>> GetAllBookingsByDateAsync(
        DateTime date,
        bool trackChanges,
        CancellationToken cancellationToken
    );

    Task<IEnumerable<Booking>> GetAllBookingsAsync(
        bool trackChanges,
        CancellationToken cancellationToken
    );
}
