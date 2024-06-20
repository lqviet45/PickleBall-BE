using Bogus;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class BookingGenerator
{
    public static Booking[] InitializeDataForBookings(
        ApplicationUser[] users,
        CourtYard[] courtYards,
        CourtGroup[] courtGroups,
        Date[] dates
    )
    {
        var usedCourtYardIds = new HashSet<Guid>();

        return new Faker<Booking>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(booking => booking.Id, f => f.Random.Guid())
            .RuleFor(booking => booking.UserId, f => f.PickRandom(users).Id)
            .RuleFor(booking => booking.CourtGroupId, f => f.PickRandom(courtGroups).Id)
            .RuleFor(
                booking => booking.CourtYardId,
                f =>
                {
                    var courtYardId = f.PickRandom(courtYards).Id;
                    while (usedCourtYardIds.Contains(courtYardId))
                        courtYardId = f.PickRandom(courtYards).Id;

                    usedCourtYardIds.Add(courtYardId);
                    return courtYardId;
                }
            )
            .RuleFor(booking => booking.DateId, f => f.PickRandom(dates).Id)
            .RuleFor(booking => booking.NumberOfPlayers, f => f.Random.Int(1, 4))
            .RuleFor(booking => booking.BookingStatus, f => f.PickRandom<BookingStatus>())
            .RuleFor(booking => booking.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(booking => booking.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(booking => booking.IsDeleted, f => f.Random.Bool())
            .Generate(50)
            .ToArray();
    }
}
