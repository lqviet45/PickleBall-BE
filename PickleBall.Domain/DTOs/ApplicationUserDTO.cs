using Microsoft.AspNetCore.Identity;

namespace PickleBall.Domain.DTOs;

public class ApplicationUserDTO : IdentityUser<Guid>
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FullName { get; set; }

    public string? IdentityId { get; set; }

    public DateTime? DayOfBirth { get; set; }

    public string? Location { get; set; }
}
