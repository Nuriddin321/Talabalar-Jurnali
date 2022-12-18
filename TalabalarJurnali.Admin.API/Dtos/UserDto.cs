using System.ComponentModel.DataAnnotations;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Admin.API.Dtos;

public class UserDto
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? ConfirmPassword { get; set; }

    public IFormFile? AvatarUrl { get; set; }
    public ERole Role { get; set; }
}
