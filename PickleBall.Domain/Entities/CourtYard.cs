using PickleBall.Domain.Abstractions;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Domain.Entities
{
    public class CourtYard : Entity<Guid>, IAuditableEntity
    {
        public Guid CourtGroupId { get; set; }
        public string? Name { get; set; }
        public CourtYardStatus CourtYardStatus { get; set; }
        public string? Type { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public virtual ICollection<Cost> Costs { get; set; } = [];
        public virtual CourtGroup? CourtGroup { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; } = [];
        public virtual ICollection<Slot> Slots { get; set; } = [];
    }
}
