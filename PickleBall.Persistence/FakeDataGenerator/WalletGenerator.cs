using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class WalletGenerator
{
    public static Wallet[] InitializeDataForWallets(ApplicationUser[] users)
    {
        var usedUserIds = new HashSet<Guid>();

        return new Faker<Wallet>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(
                wallet => wallet.Type,
                f =>
                {
                    var accountName = f.Finance.AccountName();
                    return accountName.Length > 20 ? accountName.Substring(0, 20) : accountName;
                }
            )
            .RuleFor(wallet => wallet.Id, f => f.Random.Guid())
            .RuleFor(
                wallet => wallet.UserId,
                f =>
                {
                    var userId = f.PickRandom(users).Id;
                    while (usedUserIds.Contains(userId))
                        userId = f.PickRandom(users).Id;

                    usedUserIds.Add(userId);
                    return userId;
                }
            )
            .RuleFor(wallet => wallet.Balance, f => f.Finance.Amount(1, 1000))
            .RuleFor(wallet => wallet.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(wallet => wallet.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(wallet => wallet.IsDeleted, f => f.Equals(false))
            .Generate(50)
            .ToArray();
    }
}
