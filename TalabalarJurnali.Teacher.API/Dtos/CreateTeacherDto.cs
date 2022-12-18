using System.ComponentModel.DataAnnotations;

namespace TalabalarJurnali.Teacher.API.Dtos;

public class CreateTeacherDto
{
    [Required]
    public string? Username { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}