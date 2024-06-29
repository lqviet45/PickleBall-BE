namespace PickleBall.Domain.DTOs.CourtGroupsDtos;

public class UpdateCourtGroupDto
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public int MinSlots { get; set; }
    public int MaxSlots { get; set; }
}
