using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable(TableNames.Booking);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.UserId).IsRequired();

            builder.Property(c => c.CourtYardId).IsRequired();

            builder.Property(c => c.CourtGroupId).IsRequired();

            builder.Property(c => c.NumberOfPlayers).IsRequired();

            builder.Property(c => c.Status).HasMaxLength(20).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder
                .HasMany(b => b.SlotBookings)
                .WithOne()
                .HasForeignKey(sb => sb.BookingId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
