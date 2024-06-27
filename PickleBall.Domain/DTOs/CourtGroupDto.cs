using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PickleBall.Domain.Entities;

namespace PickleBall.Domain.DTOs
{
    public class CourtGroupDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int MinSlots { get; set; }
        public int MaxSlots { get; set; }
        public string? Location { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public ICollection<CourtYardDto> CourtYards { get; set; } = [];
        public ICollection<MediaDto> Medias { get; set; } = [];
        public ApplicationUserDto? User { get; set; }
        public WardDto? Ward { get; set; }
    }
}
