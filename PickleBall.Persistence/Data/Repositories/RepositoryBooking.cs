using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;
using PickleBall.Domain.Paging;

namespace PickleBall.Persistence.Data.Repositories;

internal sealed class RepositoryBooking(ApplicationDbContext context)
    : RepositoryBase<Booking>(context),
        IRepositoryBooking
{
    public async Task<Booking?> GetBookingByIdAsync(
        Guid bookingId,
        bool trackChanges,
        CancellationToken cancellationToken
    ) =>
        await GetEntityByConditionAsync(
            booking => booking.Id == bookingId,
            trackChanges,
            cancellationToken,
            query =>
                query
                    .Include(booking => booking.CourtGroup)
                    .Include(b => b.CourtYard)
                    .Include(booking => booking.Date)
        );

    public async Task<IEnumerable<Booking>> GetAllBookingsByConditionAsync(
        Expression<Func<Booking, bool>> expression,
        bool trackChanges,
        BookingParameters bookingParameters,
        CancellationToken cancellationToken
    ) =>
        await GetEntitiesByConditionAsync(
            expression,
            trackChanges,
            cancellationToken,
            query =>
                query
                    .Include(booking => booking.CourtGroup)
                    .Include(b => b.CourtYard)
                    .Include(booking => booking.Date)
                    .Skip((bookingParameters.PageNumber - 1) * bookingParameters.PageSize)
                    .Take(bookingParameters.PageSize)
        );

    public async Task<IEnumerable<Booking>> GetAllBookingsAsync(
        bool trackChanges,
        BookingParameters bookingParameters,
        CancellationToken cancellationToken
    ) =>
        await GetAllAsync(
            trackChanges,
            cancellationToken,
            query =>
                query
                    .Include(booking => booking.CourtGroup)
                    .Include(b => b.CourtYard)
                    .Include(booking => booking.Date)
                    .Where(booking => booking.BookingStatus == BookingStatus.Pending)
                    .Skip((bookingParameters.PageNumber - 1) * bookingParameters.PageSize)
                    .Take(bookingParameters.PageSize)
        );
}
