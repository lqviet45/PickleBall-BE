using PickleBall.Domain.Entities;

namespace PickleBall.Domain.DTOs;

public class WalletDto
{
    public Guid Id { get; set; }
    public decimal Balance { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    public string FormattedCreatedOnUtc => CreatedOnUtc.ToString("dd-MM-yyyy");
    // public string FormattedModifiedOnUtc => ModifiedOnUtc.ToString("dd-MM-yyyy");

    public ICollection<TransactionDto> Transactions { get; set; } = [];
    public ICollection<DepositDto> Deposits { get; set; } = [];
}
