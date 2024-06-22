using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;
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

            builder
                .Property(c => c.CourtYardStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (CourtYardStatus)Enum.Parse(typeof(CourtYardStatus), v)
                )
                .IsRequired();

            builder.Property(c => c.Type).HasMaxLength(20).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder.HasQueryFilter(c => !c.IsDeleted);

            builder
                .HasMany(c => c.Bookings)
                .WithOne(c => c.CourtYard)
                .HasForeignKey(b => b.CourtYardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(c => c.Costs)
                .WithOne(c => c.CourtYard)
                .HasForeignKey(c => c.CourtYardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(c => c.Slots)
                .WithOne(c => c.CourtYard)
                .HasForeignKey(s => s.CourtYardId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
