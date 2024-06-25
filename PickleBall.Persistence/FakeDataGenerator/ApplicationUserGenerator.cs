using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class ApplicationUserGenerator
{
    public static ApplicationUser[] InitializeDataForApplicationUsers()
    {
        var userIdList = new HashSet<Guid>();

        return new Faker<ApplicationUser>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(user => user.Id, f =>
            {
                var userId = f.Random.Guid();

                userIdList.Add(userId);
                return userId;
            })
            .RuleFor(user => user.FirstName, f => f.Person.FirstName)
            .RuleFor(user => user.LastName, f => f.Person.LastName)
            .RuleFor(user => user.FullName, (f, user) => $"{user.FirstName} {user.LastName}")
            .RuleFor(user => user.IdentityId, f => f.Random.Guid().ToString())
            .RuleFor(user => user.DayOfBirth, f => f.Date.Past())
            .RuleFor(user => user.Location, f => f.Address.City())
            .RuleFor(user => user.SupervisorId, f => f.PickRandom<Guid>(userIdList))
            .Generate(50)
            .ToArray();
    }
}
