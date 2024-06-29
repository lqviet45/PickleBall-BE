using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PickleBall.Domain.DTOs.ApplicationUserDtos;

public class CreateManagerDto
{
    [EmailAddress]
    public string? Email { get; init; }

    public string? Password { get; init; }

    [Required(ErrorMessage = "First Name is required")]
    public string? FirstName { get; init; }

    [Required(ErrorMessage = "Last Name is required")]
    public string? LastName { get; init; }

    [Required(ErrorMessage = "Location is required")]
    public string? Location { get; init; }
}
