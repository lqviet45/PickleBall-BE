using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Domain.DTOs;

public class BookingDto
{
    public Guid Id { get; set; }
    public Guid CourtYardId { get; set; } = Guid.Empty;
    public Guid CourtGroupId { get; set; }
    public Guid UserId { get; set; }
    public Guid DateId { get; set; }
    public int NumberOfPlayers { get; set; }
    public BookingStatus BookingStatus { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    public virtual DateDto? Date { get; set; }
    public virtual CourtGroupDto? CourtGroup { get; set; }
}
