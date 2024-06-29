namespace PickleBall.Domain.DTOs.BookingDtos;

public class UpdateBookingDto
{
    public Guid CourtYardId { get; init; }
    public bool IsApproved { get; init; }
}
