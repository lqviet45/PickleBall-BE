using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public sealed class CourtGroupConfiguration : IEntityTypeConfiguration<CourtGroup>
    {
        public void Configure(EntityTypeBuilder<CourtGroup> builder)
        {
            builder.ToTable(TableNames.CourtGroup);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.UserId).IsRequired();

            builder.Property(c => c.WardId).IsRequired();

            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();

            builder.Property(c => c.MinSlots).IsRequired();

            builder.Property(c => c.MaxSlots).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder.HasQueryFilter(c => !c.IsDeleted);

            builder
                .HasMany(c => c.BookMarks)
                .WithOne(b => b.CourtGroup)
                .HasForeignKey(b => b.CourtGroupId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(c => c.Medias)
                .WithOne(b => b.CourtGroup)
                .HasForeignKey(m => m.CourtGroupId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(c => c.Bookings)
                .WithOne(b => b.CourtGroup)
                .HasForeignKey(b => b.CourtGroupId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(c => c.CourtYards)
                .WithOne(b => b.CourtGroup)
                .HasForeignKey(cy => cy.CourtGroupId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Wallet)
                .WithOne(b => b.CourtGroup)
                .HasForeignKey<CourtGroup>(w => w.WalletId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(c => c.DateCourtGroups)
                .WithOne(d => d.CourtGroup)
                .HasForeignKey(d => d.CourtGroupId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
