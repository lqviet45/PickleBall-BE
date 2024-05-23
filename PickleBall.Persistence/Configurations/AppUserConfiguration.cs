using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations;

public sealed class AppUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.ToTable(TableNames.ApplicationUserTable);

        builder.HasKey(x => x.Id);
        builder.Property(u => u.FirstName)
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(u => u.LastName)
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(u => u.FullName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(u => u.Location)
            .HasMaxLength(200)
            .IsRequired();

        builder.HasOne(u => u.Wallets)
            .WithOne(w => w.User);
    }
}