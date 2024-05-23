using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class City : Entity<int>, IAuditableEntity
    {
        public string? Name { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public virtual ICollection<District> Districts { get; set; } = [];
    }
}
