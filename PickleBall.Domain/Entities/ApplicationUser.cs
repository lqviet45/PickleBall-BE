using Microsoft.AspNetCore.Identity;

namespace PickleBall.Domain.Entities;

public class ApplicationUser : IdentityUser<Guid>
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FullName { get; set; }
    
    public DateTime? DayOfBirth { get; set; }
    
    public string? Location { get; set; }
}