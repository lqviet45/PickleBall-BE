using System.Numerics;
using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class Wallet : Entity<Guid>, IAuditableEntity
    {
        public string Type { get; set; }
        public Guid UserId { get; set; }
        public Guid CourtGroupId { get; set; }
        public decimal balance { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public virtual CourtGroup? CourtGroup { get; set; }
        public virtual ApplicationUser? User { get; set; }
        public virtual ICollection<Transaction>? Transactions { get; set; }
        public virtual ICollection<Deposit>? Deposits { get; set; }
    }
}
