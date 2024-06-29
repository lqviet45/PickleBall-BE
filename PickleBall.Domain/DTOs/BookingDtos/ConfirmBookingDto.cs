namespace PickleBall.Domain.DTOs.BookingDtos;

public class ConfirmBookingDto
{
    public Guid UserId { get; set; }
    public Guid CourtGroupId { get; set; }
    public bool IsConfirmed { get; init; }
}
