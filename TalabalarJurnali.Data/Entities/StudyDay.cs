using System.ComponentModel.DataAnnotations.Schema;

namespace TalabalarJurnali.Data.Entities
{
    public class StudyDay
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid GroupId { get; set; }
        [ForeignKey(nameof(GroupId))]
        public virtual Group? Group { get; set; }    
        public virtual List<StudentStatsOfDay>? StudentsStatsOfDay { get; set; }
    }
}
