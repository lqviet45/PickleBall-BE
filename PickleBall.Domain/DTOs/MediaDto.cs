namespace PickleBall.Domain.DTOs
{
    public class MediaDto
    {
        public Guid Id { get; set; }
        public string? MediaUrl { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
