using System.Security.Claims;
using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Student.API.Dtos;

namespace TalabalarJurnali.Student.API.Services
{
    public interface IStudentService
    {
        Task<GroupDto> GetMyGroup(ClaimsPrincipal user);
        Task<List<AppUser>> GetGroupUsers(ClaimsPrincipal user, AppUserRole role );
        Task<List<Mark>> GetStudentMarksForLastXdays(Guid id, ClaimsPrincipal user, uint x);
        Task<List<StudentStatsOfDay>> GetStudentsStatsForLastXdays(ClaimsPrincipal user, uint x);

    }
}
