using System.Security.Claims;
using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Student.API.Dtos;

namespace TalabalarJurnali.Student.API.Services
{
    public interface IStudentService
    {
        Task<GroupDto> GetMyGroup(ClaimsPrincipal user);
        List<AppUser> GetGroupUsers(ClaimsPrincipal _user, ERole role);
        Task<List<Mark>> GetStudentMarksForLastXdays(Guid id, ClaimsPrincipal user, uint x);
    }
}
