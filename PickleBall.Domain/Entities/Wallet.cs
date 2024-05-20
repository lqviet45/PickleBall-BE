using PickleBall.Domain.Abstractions;
using System.Numerics;

namespace PickleBall.Domain.Entities
{
    public class Wallet : Entity<Guid>, IAuditableEntity
    {
        public string Type { get; set; }
        public Guid UserId { get; set; }
        public Guid CourtGroupId { get; set; }
        public BigInteger balance { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
