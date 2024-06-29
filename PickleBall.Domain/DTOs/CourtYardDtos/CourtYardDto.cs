using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Domain.DTOs.CourtYardDtos;

public class CourtYardDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public CourtYardStatus CourtYardStatus { get; set; }
    public string? Type { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    // Relationships
    public ICollection<SlotDto> Slots { get; set; } = [];
}
