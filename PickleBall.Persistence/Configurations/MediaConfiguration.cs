using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Persistence.Configurations
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.ToTable(TableNames.Media);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.UserId)
                .IsRequired();

            builder.Property(c => c.CourtGroupId)
                .IsRequired();

            builder.Property(c => c.MediaUrl)
                .HasMaxLength(int.MaxValue)
                .IsRequired();

            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
