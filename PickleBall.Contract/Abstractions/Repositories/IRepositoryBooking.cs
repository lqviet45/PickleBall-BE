using PickleBall.Domain.Entities;
using PickleBall.Domain.Paging;

namespace PickleBall.Contract.Abstractions.Repositories;

public interface IRepositoryBooking : IRepositoryBase<Booking>
{
    Task<Booking?> GetBookingByIdAsync(
        Guid bookingId,
        bool trackChanges,
        CancellationToken cancellationToken
    );

    Task<IEnumerable<Booking>> GetAllBookingsByDateAsync(
        Guid dateId,
        bool trackChanges,
        BookingParameters bookingParameters,
        CancellationToken cancellationToken
    );

    Task<IEnumerable<Booking>> GetAllBookingsAsync(
        bool trackChanges,
        BookingParameters bookingParameters,
        CancellationToken cancellationToken
    );

    Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(
        Guid userId,
        bool trackChanges,
        BookingParameters bookingParameters,
        CancellationToken cancellationToken
    );
}
