using Bogus;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class DepositGenerator
{
    public static Deposit[] InitializeDataForDeposits(ApplicationUser[] users, Wallet[] wallets)
    {
        return new Faker<Deposit>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(deposit => deposit.Id, f => f.Random.Guid())
            .RuleFor(deposit => deposit.UserId, f => f.PickRandom(users).Id)
            .RuleFor(deposit => deposit.WalletId, f => f.PickRandom(wallets).Id)
            .RuleFor(deposit => deposit.Amount, f => f.Finance.Amount(1, 1000))
            .RuleFor(deposit => deposit.Status, f => f.Lorem.Word())
            .RuleFor(deposit => deposit.Description, f => f.Lorem.Sentence())
            .RuleFor(deposit => deposit.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(deposit => deposit.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(deposit => deposit.IsDeleted, f => f.Random.Bool())
            .Generate(50)
            .ToArray();
    }
}
