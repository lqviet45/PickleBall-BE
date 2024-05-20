using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class Ward : Entity<Guid>, IAuditableEntity
    {
        public string Name { get; set; }
        public int DistrictId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
