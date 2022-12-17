namespace TalabalarJurnali.Data.Entities
{
    public class StudyDay
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public List<StudentStatsOfDay> StudentsStatsOfDay { get; set; }
    }
}
