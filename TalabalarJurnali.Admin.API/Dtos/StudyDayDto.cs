using System.ComponentModel.DataAnnotations.Schema;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Admin.API.Dtos;

public class StudyDayDto
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public Guid GroupId { get; set; }
    public virtual List<StudentStatsOfDay>? StudentsStatsOfDay { get; set; }
}
