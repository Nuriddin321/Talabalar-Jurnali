using System.ComponentModel.DataAnnotations;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Admin.API.Dtos;

public class UpdateGroupDto
{
    [Required]
    public string? Name { get; set; }

    public EGroupStatus Status { get; set; }

    [Required]
    public DateTime StatDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }
}
