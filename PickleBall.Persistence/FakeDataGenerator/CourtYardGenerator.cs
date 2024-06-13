using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class CourtYardGenerator
{
    public static CourtYard[] InitializeDataForCourtYards(CourtGroup[] courtGroups)
    {
        return new Faker<CourtYard>()
            .UseSeed(2)
            .RuleFor(courtYard => courtYard.Id, f => f.Random.Guid())
            .RuleFor(courtYard => courtYard.CourtGroupId, f => f.PickRandom(courtGroups).Id)
            .RuleFor(courtYard => courtYard.SlotId, f => f.Random.Guid())
            .RuleFor(courtYard => courtYard.Name, f => f.Lorem.Word())
            .RuleFor(courtYard => courtYard.Status, f => f.Lorem.Word())
            .RuleFor(courtYard => courtYard.Type, f => f.Lorem.Word())
            .RuleFor(courtYard => courtYard.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(courtYard => courtYard.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(courtYard => courtYard.IsDeleted, f => f.Random.Bool())
            .Generate(50)
            .ToArray();
    }
}
