using System.Reflection.Metadata.Ecma335;
using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class DateCourtGroupGenerator
{
    public static DateCourtGroup[] InitializeDataForDateCourtGroup(
        CourtGroup[] courtGroups,
        Date[] dates
    )
    {
        return new Faker<DateCourtGroup>()
            .UseSeed(2)
            .RuleFor(date => date.Id, f => f.Random.Guid())
            .RuleFor(date => date.CourtGroupId, f => f.PickRandom(courtGroups).Id)
            .RuleFor(date => date.DateId, f => f.PickRandom(dates).Id)
            .RuleFor(date => date.IsClosed, f => f.Random.Bool())
            .RuleFor(date => date.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(date => date.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(date => date.IsDeleted, f => f.Equals(false))
            .Generate(50)
            .ToArray();
    }
}
