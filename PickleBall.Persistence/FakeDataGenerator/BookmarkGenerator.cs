using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class BookmarkGenerator
{
    public static BookMark[] InitializeDataForBookMarks(
        ApplicationUser[] users,
        CourtGroup[] courtGroups
    )
    {
        return new Faker<BookMark>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(bookmark => bookmark.Id, f => f.Random.Guid())
            .RuleFor(bookmark => bookmark.UserId, f => f.PickRandom(users).Id)
            .RuleFor(bookmark => bookmark.CourtGroupId, f => f.PickRandom(courtGroups).Id)
            .RuleFor(bookmark => bookmark.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(bookmark => bookmark.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(bookmark => bookmark.IsDeleted, f => f.Equals(false))
            .Generate(50)
            .ToArray();
    }
}
