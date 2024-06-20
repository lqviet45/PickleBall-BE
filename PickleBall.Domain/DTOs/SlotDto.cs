namespace PickleBall.Domain.DTOs
{
    public class SlotDto
    {
        public Guid Id { get; set; }
        public Guid CourtYardId { get; set; }
        public string? SlotName { get; set; }
        public string? Status { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
