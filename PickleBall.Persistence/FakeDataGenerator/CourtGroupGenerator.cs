using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class CourtGroupGenerator
{
    public static CourtGroup[] InitializeDataForCourtGroups(
        ApplicationUser[] users,
        Ward[] wards,
        Wallet[] wallets
    )
    {

        return new Faker<CourtGroup>()
            .UseSeed(1)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(courtGroup => courtGroup.Id, f => f.Random.Guid())
            .RuleFor(courtGroup => courtGroup.UserId, f => f.PickRandom(users).Id)
            .RuleFor(courtGroup => courtGroup.WardId, f => f.PickRandom(wards).Id)
            .RuleFor(courtGroup => courtGroup.Name, f => f.Company.CompanyName())
            .RuleFor(courtGroup => courtGroup.Price, f => f.Random.Decimal(1, 100))
            .RuleFor(courtGroup => courtGroup.MinSlots, f => f.Random.Number(1, 5))
            .RuleFor(courtGroup => courtGroup.MaxSlots, f => f.Random.Number(5, 10))
            .RuleFor(courtGroup => courtGroup.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(courtGroup => courtGroup.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(courtGroup => courtGroup.IsDeleted, f => f.Random.Bool())
            .Generate(50)
            .ToArray();
    }
}
