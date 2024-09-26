using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities;

public class TransactionProduct : Entity<Guid>, IAuditableEntity
{
    public Guid TransactionId { get; set; }
    public Guid ProductId { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    
    // Relationships
    public virtual Transaction? Transaction { get; set; }
    public virtual Product? Product { get; set; }
}