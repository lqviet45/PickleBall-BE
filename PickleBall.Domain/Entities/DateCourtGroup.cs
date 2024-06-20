using PickleBall.Domain.Abstractions;

namespace PickleBall.Domain.Entities;

public class DateCourtGroup : Entity<Guid>, IAuditableEntity
{
    public Guid DateId { get; set; }
    public Guid CourtGroupId { get; set; }
    public bool IsClosed { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    // Relationships
    public virtual CourtGroup? CourtGroup { get; set; }
    public virtual Date? Date { get; set; }
}
