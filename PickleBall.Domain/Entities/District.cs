using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class District : Entity<int>, IAuditableEntity
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
