using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations;

public class DateCourtGroupConfiguration : IEntityTypeConfiguration<DateCourtGroup>
{
    public void Configure(EntityTypeBuilder<DateCourtGroup> builder)
    {
        builder.ToTable(TableNames.DateCourtGroup);

        builder.HasKey(c => c.Id);

        builder.Property(c => c.DateId).IsRequired();

        builder.Property(c => c.CourtGroupId).IsRequired();

        builder.Property(c => c.IsClosed).IsRequired();

        builder.HasQueryFilter(c => !c.IsDeleted);
    }
}
