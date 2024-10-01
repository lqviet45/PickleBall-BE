using PickleBall.Domain.Entities;

namespace PickleBall.Domain.DTOs.Product;

public class ProductResponse
{
    public Guid Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public int Quantity { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    
    // Relationships
    public virtual ICollection<TransactionProduct> TransactionProducts { get; set; } = new List<TransactionProduct>();
    public virtual CourtGroup? CourtGroup { get; set; }
}