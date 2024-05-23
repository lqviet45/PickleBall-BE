using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class DepositConfiguration : IEntityTypeConfiguration<Deposit>
    {
        public void Configure(EntityTypeBuilder<Deposit> builder)
        {
            builder.ToTable(TableNames.Deposit);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.UserId).IsRequired();

            builder.Property(c => c.WalletId).IsRequired();

            builder.Property(c => c.Amount).IsRequired();

            builder.Property(c => c.Status).HasMaxLength(20).IsRequired();

            builder.Property(c => c.Description).HasMaxLength(150).IsRequired();

            builder.Property(c => c.TransactionId).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder
                .HasOne(d => d.Transaction)
                .WithOne(t => t.Deposit)
                .HasForeignKey<Transaction>(t => t.DepositId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
