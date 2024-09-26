using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.ProductName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Description)
            .HasMaxLength(500);
        
        builder.Property(p => p.Quantity)
            .HasDefaultValue(1)
            .IsRequired();

        builder.Property(p => p.Price)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(p => p.CreatedOnUtc);

        builder.Property(p => p.ModifiedOnUtc);
        
        builder.HasMany(p => p.TransactionProducts)
            .WithOne(tp => tp.Product)
            .HasForeignKey(tp => tp.ProductId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}