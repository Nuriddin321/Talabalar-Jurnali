using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Admin.API.Dtos;

public class CreateUserDto
{
    [Required]
    public string? FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    public IFormFile? AvatarUrl { get; set; }

    public ERole Role { get; set; }
}
