using PickleBall.Domain.DTOs.Enum;

namespace PickleBall.Domain.DTOs;

public class ApplicationUserDto
{
    public Guid Id { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FullName { get; set; }

    public string? IdentityId { get; set; }

    public DateTime? DayOfBirth { get; set; }

    public string? Location { get; set; }

    public Role Role { get; set; } = Role.Customer;

    // Relationships
    public WalletDto? Wallet { get; set; }
    public ICollection<MediaDto> Medias { get; set; } = [];
    public ICollection<ApplicationUserDto> Users { get; set; } = [];
}
