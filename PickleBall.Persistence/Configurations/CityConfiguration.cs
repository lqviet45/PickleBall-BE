using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable(TableNames.City);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder
                .HasMany(c => c.Districts)
                .WithOne(d => d.City)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
