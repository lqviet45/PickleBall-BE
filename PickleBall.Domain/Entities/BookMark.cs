﻿using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities
{
    public class BookMark : Entity<Guid>, IAuditableEntity
    {
        public Guid UserId { get; set; }
        public Guid CourtGroupId { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }

        // Relationships
        public virtual ApplicationUser? User { get; set; }
        public virtual CourtGroup? CourtGroup { get; set; }
    }
}
