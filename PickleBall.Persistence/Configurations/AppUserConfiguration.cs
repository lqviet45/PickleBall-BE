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
        builder.Property(u => u.FirstName).HasMaxLength(50).IsRequired();

        builder.Property(u => u.LastName).HasMaxLength(50).IsRequired();

        builder.Property(u => u.FullName).HasMaxLength(100).IsRequired();

        builder.HasIndex(u => u.IdentityId).IsUnique();

        builder.Property(u => u.Location).HasMaxLength(200).IsRequired();

        builder.Property(u => u.SupervisorId).IsRequired(false);
        builder.Property(u => u.DeviceToken).IsRequired(false);

        builder
            .HasMany(u => u.BookMarks)
            .WithOne(b => b.User)
            .HasForeignKey(b => b.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(u => u.CourtGroups)
            .WithOne(b => b.User)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(u => u.Deposits)
            .WithOne(b => b.User)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(u => u.Medias)
            .WithOne(b => b.User)
            .HasForeignKey(m => m.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(u => u.Transactions)
            .WithOne(b => b.User)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(u => u.Users)
            .WithOne(b => b.Supervisor)
            .HasForeignKey(u => u.SupervisorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(u => u.Wallets).WithOne(w => w.User);
    }
}
