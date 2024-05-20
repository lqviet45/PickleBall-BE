

using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class CourtGroup : Entity<Guid>, IAuditableEntity
    {
        public Guid UserId { get; set; }
        public Guid WardId { get; set; }
        public string Name { get; set; }
        public int MinSlots { get; set; }
        public int MaxSlots { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
