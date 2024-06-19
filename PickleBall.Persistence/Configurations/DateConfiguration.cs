using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Domain.Entities.Enums;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations;

public class DateConfiguration : IEntityTypeConfiguration<Date>
{
    public void Configure(EntityTypeBuilder<Date> builder)
    {
        builder.ToTable(TableNames.Date);

        builder.HasKey(c => c.Id);

        builder.Property(c => c.DateWorking).IsRequired();

        builder
            .Property(c => c.DateStatus)
            .HasConversion(v => v.ToString(), v => (DateStatus)Enum.Parse(typeof(DateStatus), v))
            .IsRequired();

        builder.HasQueryFilter(c => !c.IsDeleted);

        builder
            .HasMany(c => c.Bookings)
            .WithOne(c => c.Date)
            .HasForeignKey(c => c.DateId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(c => c.DateCourtGroups)
            .WithOne(c => c.Date)
            .HasForeignKey(c => c.DateId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
