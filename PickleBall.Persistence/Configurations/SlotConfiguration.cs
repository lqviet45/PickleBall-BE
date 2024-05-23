using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class SlotConfiguration : IEntityTypeConfiguration<Slot>
    {
        public void Configure(EntityTypeBuilder<Slot> builder)
        {
            builder.ToTable(TableNames.Slot);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.CourtYardId).IsRequired();

            builder.Property(c => c.SlotName).HasMaxLength(50).IsRequired();

            builder.Property(c => c.Status).HasMaxLength(20).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder
                .HasMany(s => s.SlotBookings)
                .WithOne()
                .HasForeignKey(sb => sb.SlotId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
