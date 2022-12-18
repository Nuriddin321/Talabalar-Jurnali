using System.Security.Claims;
using Mapster;
using Microsoft.AspNetCore.Identity;
using TalabalarJurnali.Data.Data;
using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Student.API.Dtos;

namespace TalabalarJurnali.Student.API.Services
{
    public class StudentService : IStudentService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppUserRole> _roleManager;
        private readonly AppDbContext _context;

        public StudentService(UserManager<AppUser> userManager, RoleManager<AppUserRole> roleManager, AppDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }
        public async Task<GroupDto> GetMyGroup(ClaimsPrincipal _user)
        {
            var user = await _userManager.GetUserAsync(_user);
            return user.Group.Adapt<GroupDto>();
        }

        public  List<AppUser> GetGroupUsers(ClaimsPrincipal _user, ERole role)
        {
            var group =   _userManager.GetUserAsync(_user).Result.Group;

            return group.Users.Where(u => u.UserRole == role).ToList();
        }

        public async Task<List<Mark>> GetStudentMarksForLastXdays(Guid id, ClaimsPrincipal _user, uint x, EMarkType markType)
        {
            var user = await _userManager.GetUserAsync(_user);
            if (user is null)
                return null;

            var userMarks=  _context.Marks.Where(m => m.UserId == user.Id).Where(m => m.Type == markType ).ToList();
            var orderedMarksByDate = userMarks.OrderBy(m => m.MarkDate).ToList();
            orderedMarksByDate.Reverse(0, orderedMarksByDate.Count);

            return orderedMarksByDate.GetRange(0, (int)x);
        }
    }
}
