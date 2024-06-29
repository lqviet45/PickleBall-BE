using PickleBall.Domain.DTOs.ApplicationUserDtos;
using PickleBall.Domain.DTOs.CourtGroupsDtos;

namespace PickleBall.Domain.DTOs
{
    public class BookMarkDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public ApplicationUserDto? User { get; set; }
        public CourtGroupDto? CourtGroup { get; set; }
    }
}
