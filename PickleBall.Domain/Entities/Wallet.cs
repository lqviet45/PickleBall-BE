using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class Wallet : Entity<Guid>, IAuditableEntity
    {
        public string? Type { get; set; }
        public Guid UserId { get; set; }
        public decimal Balance { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public virtual ApplicationUser? User { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; } = [];
        public virtual ICollection<Deposit> Deposits { get; set; } = [];
    }
}
