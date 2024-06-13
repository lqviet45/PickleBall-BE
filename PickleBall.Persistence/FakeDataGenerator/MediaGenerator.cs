using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class MediaGenerator
{
    public static Media[] InitializeDataForMedia(ApplicationUser[] users, CourtGroup[] courtGroups)
    {
        return new Faker<Media>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(media => media.Id, f => f.Random.Guid())
            .RuleFor(media => media.MediaUrl, f => f.Internet.Url())
            .RuleFor(media => media.UserId, f => f.PickRandom(users).Id)
            .RuleFor(media => media.CourtGroupId, f => f.PickRandom(courtGroups).Id)
            .RuleFor(media => media.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(media => media.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(media => media.IsDeleted, f => f.Random.Bool())
            .Generate(50)
            .ToArray();
    }
}
