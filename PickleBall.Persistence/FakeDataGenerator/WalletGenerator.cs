using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class WalletGenerator
{
    public static Wallet[] InitializeDataForWallets(ApplicationUser[] users)
    {
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
            .RuleFor(wallet => wallet.UserId, f => f.PickRandom(users).Id)
            .RuleFor(wallet => wallet.Balance, f => f.Finance.Amount(1, 1000))
            .RuleFor(wallet => wallet.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(wallet => wallet.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(wallet => wallet.IsDeleted, f => f.Random.Bool())
            .Generate(50)
            .ToArray();
    }
}
