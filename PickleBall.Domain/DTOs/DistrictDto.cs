namespace PickleBall.Domain.DTOs
{
    public class DistrictDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CityId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
