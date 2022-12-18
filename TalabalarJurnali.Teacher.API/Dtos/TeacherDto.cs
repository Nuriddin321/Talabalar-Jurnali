namespace TalabalarJurnali.Teacher.API.Dtos;

public class TeacherDto
{
    public Guid  Id{ get; set; }
    public string? Username { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? AvatarUrl { get; set; }
}