using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.ToTable(TableNames.Wallet);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.UserId).IsRequired();

            builder.Property(c => c.Type).HasMaxLength(20).IsRequired();

            builder.Property(c => c.Balance).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder
                .HasOne(w => w.User)
                .WithOne(w => w.Wallets)
                .HasForeignKey<Wallet>(w => w.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(w => w.CourtGroup)
                .WithOne(w => w.Wallet)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(w => w.Transactions)
                .WithOne(w => w.Wallet)
                .HasForeignKey(w => w.WalletId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.CourtGroup)
                .WithOne(w => w.Wallet)
                .HasForeignKey<CourtGroup>(w => w.WalletId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(w => w.Deposits)
                .WithOne(w => w.Wallet)
                .HasForeignKey(d => d.WalletId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
