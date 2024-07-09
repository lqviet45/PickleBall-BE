namespace PickleBall.Domain.DTOs.BookingDtos;

public class ConfirmBookingDto
{
    public Guid CourtYardId { get; init; }
    public bool IsConfirmed { get; init; }
}
