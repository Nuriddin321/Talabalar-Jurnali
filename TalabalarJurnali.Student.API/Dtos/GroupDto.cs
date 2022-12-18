using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Student.API.Dtos
{
    public class GroupDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public EGroupStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
