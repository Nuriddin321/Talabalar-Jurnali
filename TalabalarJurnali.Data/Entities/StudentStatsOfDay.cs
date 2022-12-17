using System.ComponentModel.DataAnnotations.Schema;

namespace TalabalarJurnali.Data.Entities;

public class StudentStatsOfDay
{
    public Guid Id { get; set; }
    public ELessonParticipatingStatus LessonParticipatingStatus { get; set; }
    public uint? LatenessTime { get; set; }  
    public Guid StudyDayId { get; set; }
    [ForeignKey(nameof(StudyDayId))]
    public virtual StudyDay? StudyDay { get; set; }
    public virtual List<Mark>? Marks { get; set; }
}
