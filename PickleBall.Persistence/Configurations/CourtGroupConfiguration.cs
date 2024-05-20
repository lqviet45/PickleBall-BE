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
    public sealed class CourtGroupConfiguration : IEntityTypeConfiguration<CourtGroup>
    {
        public void Configure(EntityTypeBuilder<CourtGroup> builder)
        {
            builder.ToTable(TableNames.CourtGroup);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.UserId)
                .IsRequired();

            builder.Property(c => c.WardId)
                .IsRequired();

            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.MinSlots)
                .IsRequired();

            builder.Property(c => c.MaxSlots)
                .IsRequired();

            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
