using PickleBall.Domain.Abstractions;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Domain.Entities
{
    public class Booking : Entity<Guid>, IAuditableEntity
    {
        public Guid? CourtYardId { get; set; }
        public Guid CourtGroupId { get; set; }
        public Guid UserId { get; set; }
        public Guid DateId { get; set; }
        public int NumberOfPlayers { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public virtual Date? Date { get; set; }
        public virtual CourtGroup? CourtGroup { get; set; }
        public virtual CourtYard? CourtYard { get; set; }
        public virtual ICollection<SlotBooking> SlotBookings { get; set; } = [];
    }
}
