namespace TalabalarJurnali.Data.Entities
{
    public class Group
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public EGroupStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<AppUser>? Users { get; set; }
        public virtual List<StudyDay>? StudyDays { get; set; }
    }
}
