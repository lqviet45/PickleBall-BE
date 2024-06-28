using PickleBall.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Domain.DTOs
{
    public class BookMarkDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public ApplicationUser? User { get; set; }
        public CourtGroup? CourtGroup { get; set; }
    }
}
