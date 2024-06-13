using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class BookingGenerator
{
    public static Booking[] InitializeDataForBookings(
        ApplicationUser[] users,
        CourtYard[] courtYards
    )
    {
        return new Faker<Booking>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(booking => booking.Id, f => f.Random.Guid())
            .RuleFor(booking => booking.UserId, f => f.PickRandom(users).Id)
            .RuleFor(booking => booking.CourtYardId, f => f.PickRandom(courtYards).Id)
            .RuleFor(booking => booking.NumberOfPlayers, f => f.Random.Int(1, 4))
            .RuleFor(booking => booking.Status, f => f.Lorem.Word())
            .RuleFor(booking => booking.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(booking => booking.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(booking => booking.IsDeleted, f => f.Random.Bool())
            .Generate(50)
            .ToArray();
    }
}
