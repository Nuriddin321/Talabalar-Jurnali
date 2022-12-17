namespace TalabalarJurnali.Data.Entities
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public EGroupStatus Status { get; set; }
        public DateTime StatDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid TeacherId { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
        public List<StudyDay> StudyDays { get; set; }
    }
}
