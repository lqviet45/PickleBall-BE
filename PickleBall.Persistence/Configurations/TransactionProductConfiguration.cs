using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;

namespace PickleBall.Persistence.Configurations;

public class TransactionProductConfiguration : IEntityTypeConfiguration<TransactionProduct>
{
    public void Configure(EntityTypeBuilder<TransactionProduct> builder)
    {
        builder.HasKey(tp => tp.Id);
    }
}