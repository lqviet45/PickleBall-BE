using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Domain.DTOs;

public class DateDto
{
    public DateTime DateWorking { get; set; }
    public DateStatus DateStatus { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}
