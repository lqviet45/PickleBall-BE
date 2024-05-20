
using PickleBall.Domain.Abstractions;
using System.Numerics;

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
    }
}
