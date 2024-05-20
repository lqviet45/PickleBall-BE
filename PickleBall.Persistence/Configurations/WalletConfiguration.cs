using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Persistence.Configurations
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.ToTable(TableNames.Wallet);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.UserId)
                .IsRequired();

            builder.Property(c => c.CourtGroupId)
                .IsRequired();

            builder.Property(c => c.Type)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.balance)
                .IsRequired();

            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
