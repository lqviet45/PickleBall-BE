using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.CourtGroupsDtos;
using PickleBall.Domain.DTOs.CourtYardDtos;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Domain.DTOs.BookingDtos;

public class BookingDto
{
    public Guid Id { get; set; }

    // public Guid CourtYardId { get; set; } = Guid.Empty;
    // public Guid CourtGroupId { get; set; }
    // public Guid UserId { get; set; }
    // public Guid DateId { get; set; }
    public int NumberOfPlayers { get; set; }
    public string? TimeRange { get; set; }
    public decimal Amount { get; set; } = 0;
    public BookingStatus BookingStatus { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    // Relationships
    public CourtYardDto? CourtYard { get; set; }
    public CourtGroupDto? CourtGroup { get; set; }
    public DateDto? Date { get; set; }
    public ApplicationUserDto? User { get; set; }
    public WalletDto? Wallet { get; set; }
}
