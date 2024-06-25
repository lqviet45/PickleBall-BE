using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.ToTable(TableNames.Media);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.UserId);

            builder.Property(c => c.CourtGroupId);

            builder.Property(c => c.MediaUrl).HasMaxLength(int.MaxValue).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();

            builder.HasQueryFilter(c => !c.IsDeleted);
        }
    }
}
