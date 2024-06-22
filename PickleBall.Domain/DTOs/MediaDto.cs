namespace PickleBall.Domain.DTOs
{
    public class MediaDto
    {
        public Guid Id { get; set; }
        public string? MediaUrl { get; set; }
        public Guid? UserId { get; set; }
        public Guid? CourtGroupId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
