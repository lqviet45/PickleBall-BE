using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class SlotGenerator
{
    public static Slot[] InitializeDataForSlots(CourtYard[] courtYards)
    {
        return new Faker<Slot>()
            .UseSeed(2)
            .RuleFor(slot => slot.Id, f => f.Random.Guid())
            .RuleFor(slot => slot.CourtYardId, f => f.PickRandom(courtYards).Id)
            .RuleFor(slot => slot.SlotName, f => f.Lorem.Word())
            .RuleFor(slot => slot.Status, f => f.Lorem.Word())
            .RuleFor(slot => slot.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(slot => slot.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(slot => slot.IsDeleted, f => f.Equals(false))
            .Generate(50)
            .ToArray();
    }
}
