using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class Booking : Entity<Guid>, IAuditableEntity
    {
        public Guid CourtYardId { get; set; }
        public Guid CourtGroupId { get; set; }
        public Guid UserId { get; set; }
        public int NumberOfPlayers { get; set; }
        public string Status { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
