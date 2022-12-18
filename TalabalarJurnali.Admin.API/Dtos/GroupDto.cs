using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Admin.API.Dtos
{
    public class GroupDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public EGroupStatus Status { get; set; }
        public DateTime StatDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<AppUser>? Students { get; set; }
        public virtual List<AppUser>? Teachers { get; set; }
    }
}
