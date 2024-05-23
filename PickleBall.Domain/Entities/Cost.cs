using System.Numerics;
using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class Cost : Entity<Guid>, IAuditableEntity
    {
        public decimal MorningCost { get; set; }
        public decimal Afternoon { get; set; }
        public decimal EveningCost { get; set; }
        public string CourtYardType { get; set; }
        public Guid CourtGroupId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public virtual CourtYard CourtYard { get; set; }
    }
}
