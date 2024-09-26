using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities;

public class Product : Entity<Guid>, IAuditableEntity
{
    public Guid CourtGroupId { get; set; }
    public string? ProductName { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    
    // Relationships
    public virtual ICollection<TransactionProduct> TransactionProducts { get; set; } = new List<TransactionProduct>();
    public virtual CourtGroup? CourtGroup { get; set; }
}