using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Domain.DTOs.CourtYardDtos;

public class UpdateCourtYardDto
{
    public string? Name { get; set; }
    public CourtYardStatus CourtYardStatus { get; set; }
    public string? Type { get; set; }
}
