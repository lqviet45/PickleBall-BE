using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class SlotBooking : Entity<Guid>, IAuditableEntity
    {
        public Guid SlotId { get; set; }
        public Guid BookingId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
