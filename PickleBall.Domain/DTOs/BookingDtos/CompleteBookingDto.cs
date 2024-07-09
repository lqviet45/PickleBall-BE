namespace PickleBall.Domain.DTOs.BookingDtos;

public class CompleteBookingDto
{
    public Guid UserId { get; set; }
    public Guid CourtGroupId { get; set; }
    public bool IsCompleted { get; init; }
}
