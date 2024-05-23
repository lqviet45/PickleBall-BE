using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class CourtYardConfiguration : IEntityTypeConfiguration<CourtYard>
    {
        public void Configure(EntityTypeBuilder<CourtYard> builder)
        {
            builder.ToTable(TableNames.CourtYard);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.CourtGroupId).IsRequired();

            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();

            builder.Property(c => c.SlotId).IsRequired();

            builder.Property(c => c.Status).HasMaxLength(20).IsRequired();

            builder.Property(c => c.Type).HasMaxLength(20).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder
                .HasMany(c => c.Costs)
                .WithOne()
                .HasForeignKey(c => c.CourtYardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(c => c.Slots)
                .WithOne()
                .HasForeignKey(s => s.CourtYardId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
