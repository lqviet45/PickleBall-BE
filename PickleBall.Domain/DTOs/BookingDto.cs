namespace PickleBall.Domain.DTOs;

public class BookingDto
{
    public Guid Id { get; set; }
    public Guid CourtYardId { get; set; }
    public Guid CourtGroupId { get; set; }
    public Guid UserId { get; set; }
    public int NumberOfPlayers { get; set; }
    public string? Status { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}
