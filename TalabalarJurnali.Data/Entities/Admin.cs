using Microsoft.AspNetCore.Identity;

namespace TalabalarJurnali.Data.Entities
{
    public class Admin : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
