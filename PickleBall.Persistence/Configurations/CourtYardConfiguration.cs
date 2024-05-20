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
    public class CourtYardConfiguration : IEntityTypeConfiguration<CourtYard>
    {
        public void Configure(EntityTypeBuilder<CourtYard> builder)
        {
            builder.ToTable(TableNames.CourtYard);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.CourtGroupId)
                .IsRequired();

            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.SlotId)
                .IsRequired();

            builder.Property(c => c.Status)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.Type)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
