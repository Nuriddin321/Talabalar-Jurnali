using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Admin.API.Dtos;

public class GroupDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public EGroupStatus Status { get; set; }
    public DateTime StatDate { get; set; }
    public DateTime EndDate { get; set; }
    public virtual List<UserDto>? Users { get; set; }
    public virtual List<StudyDayDto>? StudyDays { get; set; }
}
