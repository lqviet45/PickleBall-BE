using System.Linq.Expressions;
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

    Task<IEnumerable<Booking>> GetAllBookingsByConditionAsync(
        Expression<Func<Booking, bool>> expression,
        bool trackChanges,
        BookingParameters bookingParameters,
        CancellationToken cancellationToken
    );

    Task<IEnumerable<Booking>> GetAllBookingsByUserIdAsync(
        Expression<Func<Booking, bool>> expression,
        bool trackChanges,
        BookingParameters bookingParameters,
        CancellationToken cancellationToken
    );

    Task<IEnumerable<Booking>> GetAllBookingsAsync(
        bool trackChanges,
        BookingParameters bookingParameters,
        CancellationToken cancellationToken
    );
}
