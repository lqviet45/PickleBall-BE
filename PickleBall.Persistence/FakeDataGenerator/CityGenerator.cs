using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class CityGenerator
{
    public static City[] InitializeDataForCities()
    {
        int ID = 1;

        return new Faker<City>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(city => city.Id, f => ID++)
            .RuleFor(city => city.Name, f => f.Address.City())
            .RuleFor(city => city.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(city => city.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(city => city.IsDeleted, f => f.Equals(false))
            .Generate(50)
            .ToArray();
    }
}
