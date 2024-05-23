using System.Numerics;
using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class Deposit : Entity<Guid>, IAuditableEntity
    {
        public Guid UserId { get; set; }
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public Guid TransactionId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public virtual Transaction? Transaction { get; set; }
        public virtual Wallet? Wallet { get; set; }
        public virtual ApplicationUser? User { get; set; }
    }
}
