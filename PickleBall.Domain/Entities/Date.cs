using PickleBall.Domain.Abstractions;
using PickleBall.Domain.Entities.Enums;

namespace PickleBall.Domain.Entities;

public class Date : Entity<Guid>, IAuditableEntity
{
    public DateTime DateWorking { get; set; }
    public DateStatus DateStatus { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    // Relationships
    public virtual ICollection<DateCourtGroup> DateCourtGroups { get; set; } = [];
    public virtual ICollection<Booking> Bookings { get; set; } = [];
}
