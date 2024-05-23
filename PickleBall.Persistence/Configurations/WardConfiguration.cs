using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class WardConfiguration : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            builder.ToTable(TableNames.Ward);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();

            builder.Property(c => c.DistrictId).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder
                .HasMany(w => w.CourtGroups)
                .WithOne()
                .HasForeignKey(cg => cg.WardId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
