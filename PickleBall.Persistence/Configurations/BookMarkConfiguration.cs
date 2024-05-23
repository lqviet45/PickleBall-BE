using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PickleBall.Domain.Entities;
using PickleBall.Persistence.Constants;

namespace PickleBall.Persistence.Configurations
{
    public class BookMarkConfiguration : IEntityTypeConfiguration<BookMark>
    {
        public void Configure(EntityTypeBuilder<BookMark> builder)
        {
            builder.ToTable(TableNames.BookMark);

            builder.HasKey(c => c.Id);

            builder.Property(c => c.UserId).IsRequired();

            builder.Property(c => c.CourtGroupId).IsRequired();

            builder.Property(c => c.IsDeleted).HasDefaultValue(false).IsRequired();
        }
    }
}
