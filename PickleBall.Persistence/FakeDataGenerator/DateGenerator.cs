using Bogus;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class DateGenerator
{
    public static Date[] InitializeDataForDates()
    {
        return new Faker<Date>()
            .UseSeed(2)
            .RuleFor(date => date.Id, f => f.Random.Guid())
            .RuleFor(date => date.DateWorking, f => f.Date.Past())
            .RuleFor(date => date.DateStatus, f => f.PickRandom<DateStatus>())
            .RuleFor(date => date.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(date => date.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(date => date.IsDeleted, f => f.Equals(false))
            .Generate(50)
            .ToArray();
    }
}
