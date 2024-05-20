using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class CourtYard : Entity<Guid>, IAuditableEntity
    {
        public Guid CourtGroupId { get; set; }
        public Guid SlotId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
