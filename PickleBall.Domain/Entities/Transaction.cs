using PickleBall.Domain.Abstractions;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Domain.Entities
{
    public class Transaction : Entity<Guid>, IAuditableEntity
    {
        public Guid UserId { get; set; }
        public Guid WalletId { get; set; }
        public Guid? DepositId { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public decimal Amount { get; set; }
        public long OrderCode { get; set; }
        public string? Description { get; set; }
        public Guid BookingId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public virtual Wallet? Wallet { get; set; }
        public virtual Deposit? Deposit { get; set; }
        public virtual ApplicationUser? User { get; set; }
        public virtual Booking? Booking { get; set; }
        
        public virtual ICollection<TransactionProduct> TransactionProducts { get; set; } = new List<TransactionProduct>();
    }
}
