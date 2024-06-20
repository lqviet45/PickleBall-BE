using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;
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

            builder.Property(c => c.CourtYardId).IsRequired(false);

            builder.Property(c => c.CourtGroupId).IsRequired();

            builder.Property(c => c.NumberOfPlayers).IsRequired();

            builder
                .Property(c => c.BookingStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (BookingStatus)Enum.Parse(typeof(BookingStatus), v)
                )
                .IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder.HasQueryFilter(c => !c.IsDeleted);

            builder
                .HasMany(b => b.SlotBookings)
                .WithOne(b => b.Booking)
                .HasForeignKey(sb => sb.BookingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
