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
        trackChanges
            ? await _context
                .Bookings.Where(b => b.Id == bookingId)
                .Include(booking => booking.CourtGroup)
                .Include(b => b.CourtYard)
                .Include(booking => booking.Date)
                .FirstOrDefaultAsync(cancellationToken)
            : await _context
                .Bookings.Where(b => b.Id == bookingId)
                .Include(booking => booking.CourtGroup)
                .Include(b => b.CourtYard)
                .Include(booking => booking.Date)
                .AsNoTracking()
                .FirstOrDefaultAsync(cancellationToken);

    public async Task<IEnumerable<Booking>> GetAllBookingsByDateAsync(
        Guid dateId,
        bool trackChanges,
        BookingParameters bookingParameters,
        CancellationToken cancellationToken
    ) =>
        trackChanges
            ? await _context
                .Bookings.Where(b => b.DateId == dateId)
                .Include(booking => booking.CourtGroup)
                .Include(b => b.CourtYard)
                .Include(booking => booking.Date)
                .Skip((bookingParameters.PageNumber - 1) * bookingParameters.PageSize)
                .Take(bookingParameters.PageSize)
                .ToListAsync(cancellationToken)
            : await _context
                .Bookings.Where(b => b.DateId == dateId)
                .Include(booking => booking.CourtGroup)
                .Include(b => b.CourtYard)
                .Include(booking => booking.Date)
                .Skip((bookingParameters.PageNumber - 1) * bookingParameters.PageSize)
                .Take(bookingParameters.PageSize)
                .AsNoTracking()
                .ToListAsync(cancellationToken);

    public async Task<IEnumerable<Booking>> GetAllBookingsAsync(
        bool trackChanges,
        BookingParameters bookingParameters,
        CancellationToken cancellationToken
    ) =>
        trackChanges
            ? await _context
                .Bookings.Include(booking => booking.CourtGroup)
                .Include(b => b.CourtYard)
                .Include(booking => booking.Date)
                .Where(booking => booking.BookingStatus == BookingStatus.Pending)
                .Skip((bookingParameters.PageNumber - 1) * bookingParameters.PageSize)
                .Take(bookingParameters.PageSize)
                .ToListAsync(cancellationToken)
            : await _context
                .Bookings.Include(booking => booking.CourtGroup)
                .Include(b => b.CourtYard)
                .Include(booking => booking.Date)
                .Where(booking => booking.BookingStatus == BookingStatus.Pending)
                .Skip((bookingParameters.PageNumber - 1) * bookingParameters.PageSize)
                .Take(bookingParameters.PageSize)
                .AsNoTracking()
                .ToListAsync(cancellationToken);

    public async Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(
        Guid userId,
        bool trackChanges,
        BookingParameters bookingParameters,
        CancellationToken cancellationToken
    ) =>
        trackChanges
            ? await _context
                .Bookings.Include(booking => booking.CourtGroup)
                .Include(b => b.CourtYard)
                .Include(booking => booking.Date)
                .Where(booking => booking.UserId == userId)
                .Skip((bookingParameters.PageNumber - 1) * bookingParameters.PageSize)
                .Take(bookingParameters.PageSize)
                .ToListAsync(cancellationToken)
            : await _context
                .Bookings.Include(booking => booking.CourtGroup)
                .Include(b => b.CourtYard)
                .Include(booking => booking.Date)
                .Where(booking => booking.UserId == userId)
                .Skip((bookingParameters.PageNumber - 1) * bookingParameters.PageSize)
                .Take(bookingParameters.PageSize)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
}
