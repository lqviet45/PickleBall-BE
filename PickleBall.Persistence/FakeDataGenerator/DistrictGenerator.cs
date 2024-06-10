using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator
{
    public static class DistrictGenerator
    {
        public static District[] InitializeDataForDistricts(City[] cities)
        {
            int ID = 1;

            return new Faker<District>()
                .UseSeed(2)
                .UseDateTimeReference(new DateTime(2021, 1, 1))
                .RuleFor(district => district.Id, f => ID++)
                .RuleFor(district => district.CityId, f => f.PickRandom(cities).Id)
                .RuleFor(district => district.Name, f => f.Address.City())
                .RuleFor(district => district.CreatedOnUtc, f => f.Date.Past())
                .RuleFor(district => district.ModifiedOnUtc, f => f.Date.Past())
                .RuleFor(district => district.IsDeleted, f => f.Random.Bool())
                .Generate(50)
                .ToArray();
        }
    }
}
