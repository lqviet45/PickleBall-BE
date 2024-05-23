using System.Numerics;
using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class Cost : Entity<Guid>, IAuditableEntity
    {
        public BigInteger MorningCost { get; set; }
        public BigInteger Afternoon { get; set; }
        public BigInteger EveningCost { get; set; }
        public string CourtYardType { get; set; }
        public Guid CourtGroupId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public virtual CourtYard CourtYard { get; set; }
    }
}
