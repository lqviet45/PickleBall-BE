using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class CostGenerator
{
    public static Cost[] InitializeDataForCosts(CourtYard[] courtYards)
    {
        return new Faker<Cost>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(cost => cost.Id, f => f.Random.Guid())
            .RuleFor(cost => cost.MorningCost, f => f.Random.Decimal(10, 50))
            .RuleFor(cost => cost.Afternoon, f => f.Random.Decimal(10, 50))
            .RuleFor(cost => cost.EveningCost, f => f.Random.Decimal(10, 50))
            .RuleFor(cost => cost.CourtYardType, f => f.PickRandom("Indoor", "Outdoor"))
            .RuleFor(cost => cost.CourtYardId, f => f.PickRandom(courtYards).Id)
            .RuleFor(cost => cost.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(cost => cost.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(cost => cost.IsDeleted, f => f.Random.Bool())
            .Generate(50)
            .ToArray();
    }
}
