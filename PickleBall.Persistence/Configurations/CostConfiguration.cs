
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class CostConfiguration : IEntityTypeConfiguration<Cost>
    {
        public void Configure(EntityTypeBuilder<Cost> builder)
        {
            builder.ToTable(TableNames.Cost);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.MorningCost)
                .IsRequired();

            builder.Property(x => x.Afternoon)
                .IsRequired();

            builder.Property(x => x.EveningCost)
                .IsRequired();

            builder.Property(x => x.CourtYardType)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.CourtGroupId)
                .IsRequired();

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
