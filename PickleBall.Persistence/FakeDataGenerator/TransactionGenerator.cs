using Bogus;
using Microsoft.Identity.Client;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.FakeDataGenerator;

public static class TransactionGenerator
{
    public static Transaction[] InitializeDataForTransactions(
        ApplicationUser[] users,
        Wallet[] wallets,
        Deposit[] deposits
    )
    {
        var usedDepositIds = new HashSet<Guid>();

        return new Faker<Transaction>()
            .UseSeed(2)
            .UseDateTimeReference(new DateTime(2021, 1, 1))
            .RuleFor(transaction => transaction.Id, f => f.Random.Guid())
            .RuleFor(transaction => transaction.UserId, f => f.PickRandom(users).Id)
            .RuleFor(transaction => transaction.WalletId, f => f.PickRandom(wallets).Id)
            .RuleFor(
                transaction => transaction.DepositId,
                f =>
                {
                    var depositId = f.PickRandom(deposits).Id;
                    while (usedDepositIds.Contains(depositId))
                        depositId = f.PickRandom(deposits).Id;

                    usedDepositIds.Add(depositId);
                    return depositId;
                }
            )
            .RuleFor(transaction => transaction.Status, f => f.Lorem.Word())
            .RuleFor(transaction => transaction.Amount, f => f.Finance.Amount(1, 1000))
            .RuleFor(transaction => transaction.Description, f => f.Lorem.Sentence())
            .RuleFor(transaction => transaction.BookingId, f => f.Random.Guid())
            .RuleFor(transaction => transaction.CreatedOnUtc, f => f.Date.Past())
            .RuleFor(transaction => transaction.ModifiedOnUtc, f => f.Date.Past())
            .RuleFor(transaction => transaction.IsDeleted, f => f.Random.Bool())
            .Generate(50)
            .ToArray();
    }
}
