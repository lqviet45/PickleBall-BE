using PickleBall.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickleBall.Domain.Entities
{
    public class Media : Entity<Guid>, IAuditableEntity
    {
        public string MediaUrl { get; set; }
        public Guid UserId { get; set; }
        public Guid CourtGroupId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
