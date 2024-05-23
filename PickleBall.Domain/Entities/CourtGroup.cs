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

        // Relationships
        public virtual ICollection<BookMark>? BookMarks { get; set; }
        public virtual ICollection<Media>? Medias { get; set; }
        public virtual ICollection<Booking>? Bookings { get; set; }
        public virtual ICollection<CourtYard>? CourtYards { get; set; }
        public virtual ApplicationUser? User { get; set; }
        public virtual Wallet? Wallet { get; set; }
        public virtual Ward? Ward { get; set; }
    }
}
