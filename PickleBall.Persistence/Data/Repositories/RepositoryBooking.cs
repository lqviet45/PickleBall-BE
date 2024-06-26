using Microsoft.EntityFrameworkCore;
using PickleBall.Contract.Abstractions.Repositories;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

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

    public async Task<IEnumerable<Booking>> GetAllBookingsAsync(
        bool trackChanges,
        CancellationToken cancellationToken
    ) =>
        trackChanges
            ? await _context
                .Bookings.Include(booking => booking.CourtGroup)
                .Include(b => b.CourtYard)
                .Include(booking => booking.Date)
                .Where(booking => booking.BookingStatus == BookingStatus.Pending)
                .ToListAsync(cancellationToken)
            : await _context
                .Bookings.Include(booking => booking.CourtGroup)
                .Include(b => b.CourtYard)
                .Include(booking => booking.Date)
                .Where(booking => booking.BookingStatus == BookingStatus.Pending)
                .AsNoTracking()
                .ToListAsync(cancellationToken);

    public async Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(Guid userId, bool trackChanges, CancellationToken cancellationToken)
    => trackChanges
        ? await 
            _context.Bookings
            .Include(booking => booking.CourtGroup)
            .Include(b => b.CourtYard)
            .Include(booking => booking.Date)
            .Where(booking => booking.UserId == userId)
            .ToListAsync(cancellationToken)
        : await
            _context.Bookings
            .Include(booking => booking.CourtGroup)
            .Include(b => b.CourtYard)
            .Include(booking => booking.Date)
            .Where(booking => booking.UserId == userId)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
}
