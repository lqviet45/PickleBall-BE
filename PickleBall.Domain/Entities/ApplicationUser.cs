using Microsoft.AspNetCore.Identity;

namespace PickleBall.Domain.Entities;

public class ApplicationUser : IdentityUser<Guid>
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FullName { get; set; }

    public string? IdentityId { get; set; }

    public DateTime? DayOfBirth { get; set; }

    public string? Location { get; set; }
    public Guid? SupervisorId { get; set; }
    public string? DeviceToken { get; set; }
    public bool IsDeleted { get; protected set; }
    // Relationships
    public virtual ICollection<BookMark> BookMarks { get; set; } = [];
    public virtual ICollection<CourtGroup> CourtGroups { get; set; } = [];
    public virtual ICollection<Deposit> Deposits { get; set; } = [];
    public virtual ICollection<Media> Medias { get; set; } = [];
    public virtual ICollection<Transaction> Transactions { get; set; } = [];
    public virtual Wallet? Wallets { get; set; }
    public virtual ICollection<ApplicationUser> Users { get; set; } = [];
    public virtual ApplicationUser? Supervisor { get; set; }
}
