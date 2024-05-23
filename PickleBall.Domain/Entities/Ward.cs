using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class Ward : Entity<Guid>, IAuditableEntity
    {
        public string Name { get; set; }
        public int DistrictId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public virtual District District { get; set; }
        public virtual ICollection<CourtGroup> CourtGroups { get; set; }
    }
}
