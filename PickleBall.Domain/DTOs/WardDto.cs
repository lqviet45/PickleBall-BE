namespace PickleBall.Domain.DTOs
{
    public class WardDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int DistrictId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
