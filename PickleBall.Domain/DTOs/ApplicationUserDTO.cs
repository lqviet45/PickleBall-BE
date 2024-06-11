using Microsoft.AspNetCore.Identity;
using PickleBall.Domain.DTOs.Enum;

namespace PickleBall.Domain.DTOs;

public class ApplicationUserDto : IdentityUser<Guid>
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FullName { get; set; }

    public string? IdentityId { get; set; }

    public DateTime? DayOfBirth { get; set; }

    public string? Location { get; set; }

    public Role Role { get; set; }
}
