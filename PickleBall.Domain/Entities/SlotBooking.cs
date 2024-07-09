using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class SlotBooking : Entity<Guid>, IAuditableEntity
    {
        public Guid SlotId { get; set; }
        public Guid BookingId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
        public DateTime BookingDate { get; set; }

        // Relationships
        public virtual Slot? Slot { get; set; }
        public virtual Booking? Booking { get; set; }
    }
}
