using Microsoft.AspNetCore.Identity;

namespace TalabalarJurnali.Data.Entities
{
    public class Student : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
    }
}
