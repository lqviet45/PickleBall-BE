using PickleBall.Domain.Abstractions;
using System.Text.Json.Serialization;

namespace PickleBall.Domain.Entities
{
    public class Media : Entity<Guid>, IAuditableEntity
    {
        public string? MediaUrl { get; set; }
        public Guid? UserId { get; set; }
        public Guid? CourtGroupId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        [JsonIgnore]
        public virtual CourtGroup? CourtGroup { get; set; }
        public virtual ApplicationUser? User { get; set; }
    }
}
