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
        string[] timeRange =
        [
            "7:00 AM",
            "8:00 AM",
            "9:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "1:00 PM",
            "2:00 PM",
            "3:00 PM",
            "4:00 PM",
            "5:00 PM",
            "6:00 PM",
            "7:00 PM",
            "8:00 PM",
            "9:00 PM",
            "10:00 PM",
            "11:00 PM"
        ];

        return new Faker<Booking>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(booking => booking.Id, f => f.Random.Guid())
            .RuleFor(booking => booking.UserId, f => f.PickRandom(users).Id)
            .RuleFor(booking => booking.CourtGroupId, f => f.PickRandom(courtGroups).Id)
            .RuleFor(booking => booking.CourtYardId, f => f.PickRandom(courtYards).Id)
            .RuleFor(booking => booking.DateId, f => f.PickRandom(dates).Id)
            .RuleFor(booking => booking.NumberOfPlayers, f => f.Random.Int(1, 4))
            .RuleFor(booking => booking.TimeRange, f => f.PickRandom(timeRange))
            .RuleFor(booking => booking.BookingStatus, f => f.PickRandom<BookingStatus>())
            .RuleFor(booking => booking.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(booking => booking.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(booking => booking.IsDeleted, f => f.Random.Bool())
            .Generate(50)
            .ToArray();
    }
}
