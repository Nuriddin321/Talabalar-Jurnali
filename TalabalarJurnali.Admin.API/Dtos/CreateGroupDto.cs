using System.ComponentModel.DataAnnotations;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Admin.API.Dtos;

public class CreateGroupDto
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public DateTime StatDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }
}
