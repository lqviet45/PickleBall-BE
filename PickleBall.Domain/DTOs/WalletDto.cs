using PickleBall.Domain.Entities;

namespace PickleBall.Domain.DTOs;

public class WalletDto
{
    public Guid Id { get; set; }
    public decimal Balance { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    public ICollection<TransactionDto> Transactions { get; set; } = [];
    public ICollection<DepositDto> Deposits { get; set; } = [];
}
