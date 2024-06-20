namespace PickleBall.Domain.DTOs;

public class CourtYardDto
{
    public Guid Id { get; set; }
    public Guid CourtGroupId { get; set; }
    public string? Name { get; set; }
    public string? Status { get; set; }
    public string? Type { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}
