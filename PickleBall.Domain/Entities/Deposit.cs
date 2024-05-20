using PickleBall.Domain.Abstractions;
using System.Numerics;

namespace PickleBall.Domain.Entities
{
    public class Deposit : Entity<Guid>, IAuditableEntity
    {
        public Guid UserId { get; set; }
        public Guid WalletId { get; set; }
        public BigInteger Amount { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public Guid TransactionId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
