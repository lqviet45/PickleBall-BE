using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable(TableNames.Transaction);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.UserId).IsRequired();

            builder.Property(c => c.WalletId).IsRequired();

            builder.Property(c => c.DepositId).IsRequired(false);

            builder.Property(c => c.Amount).IsRequired();

            builder
                .Property(c => c.TransactionStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (TransactionStatus)Enum.Parse(typeof(TransactionStatus), v)
                )
                .IsRequired();

            builder.Property(c => c.Description).HasMaxLength(150).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder.Property(c => c.BookingId).IsRequired();

            builder.HasQueryFilter(c => !c.IsDeleted);
        }
    }
}
