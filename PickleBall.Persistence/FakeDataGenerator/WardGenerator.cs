using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class WardGenerator
{
    public static Ward[] InitializeDataForWards(District[] districts)
    {
        return new Faker<Ward>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(ward => ward.Id, f => f.Random.Guid())
            .RuleFor(ward => ward.DistrictId, f => f.PickRandom(districts).Id)
            .RuleFor(ward => ward.Name, f => f.Address.City())
            .RuleFor(ward => ward.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(ward => ward.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(ward => ward.IsDeleted, f => f.Equals(false))
            .Generate(50)
            .ToArray();
    }
}
