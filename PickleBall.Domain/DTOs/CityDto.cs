namespace PickleBall.Domain.DTOs;

public class CityDto
{
    public string? Name { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    // Relationship
    public IEnumerable<DistrictDto> Districts { get; set; } = [];
}
