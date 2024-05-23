using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable(TableNames.District);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder.Property(c => c.CityId).IsRequired();

            builder
                .HasMany(d => d.Wards)
                .WithOne(w => w.District)
                .HasForeignKey(w => w.DistrictId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
