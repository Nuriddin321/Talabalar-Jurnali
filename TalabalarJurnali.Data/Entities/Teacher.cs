using Microsoft.AspNetCore.Identity;

namespace TalabalarJurnali.Data.Entities
{
    public class Teacher : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ETeacherRole ETeacherRole { get; set; }  
        public List<Group> Groups { get; set; }
    }
}