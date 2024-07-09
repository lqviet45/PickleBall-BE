using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Domain.DTOs
{
    public class SlotBookingDto
    {
        public Guid Id { get; set; }
        public Guid SlotId { get; set; }
        public Guid BookingId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
