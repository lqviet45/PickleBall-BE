using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Abstractions;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Persistence.Configurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable(TableNames.District);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(c => c.CityId)
                .IsRequired();
        }
    }
}
