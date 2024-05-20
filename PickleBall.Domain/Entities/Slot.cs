
using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class Slot : Entity<Guid>, IAuditableEntity
    {
        public Guid CourtYardId { get; set; }
        public string SlotName { get; set; }
        public string Status { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
