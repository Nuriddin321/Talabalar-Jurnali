namespace TalabalarJurnali.Data.Entities;

public class StudentStatsOfDay
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public Student Student { get; set; }
    public bool IsLate { get; set; }
    public List<Mark> Marks { get; set; }
    public Guid StudyDayId { get; set; }
    public StudyDay StudyDay { get; set; }
}
