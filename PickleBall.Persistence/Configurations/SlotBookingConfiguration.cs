using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class SlotBookingConfiguration : IEntityTypeConfiguration<SlotBooking>
    {
        public void Configure(EntityTypeBuilder<SlotBooking> builder)
        {
            builder.ToTable(TableNames.SlotBooking);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.SlotId).IsRequired();

            builder.Property(c => c.BookingId).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder.HasQueryFilter(c => !c.IsDeleted);
        }
    }
}
