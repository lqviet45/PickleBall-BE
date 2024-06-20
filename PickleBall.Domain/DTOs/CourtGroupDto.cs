using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PickleBall.Domain.DTOs
{
    public class CourtGroupDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid WardId { get; set; }
        public Guid WalletId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int MinSlots { get; set; }
        public int MaxSlots { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
