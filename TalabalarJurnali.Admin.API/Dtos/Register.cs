using System.ComponentModel.DataAnnotations;

namespace TalabalarJurnali.Admin.API.Dtos;

public class Register
{
    [Required]
    public string? FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }
    
    [Required]
    public string? UserName { get; set; }

    [Required]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }

    [Required]
    public string? ConfirmPassword { get; set; }
    
    public IFormFile? Avatar { get; set; }
}
