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
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable(TableNames.City);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
