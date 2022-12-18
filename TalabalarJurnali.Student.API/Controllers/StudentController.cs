using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TalabalarJurnali.Data.Data;
using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Student.API.Services;

namespace TalabalarJurnali.Student.API.Controllers
{
    public class StudentController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;

        private readonly StudentService _studentService;
        //Task<GroupDto> GetMyGroup(ClaimsPrincipal user);
        //List<AppUser> GetGroupUsers(ClaimsPrincipal _user, ERole role);
        //Task<List<Mark>> GetStudentMarksForLastXdays(Guid id, ClaimsPrincipal user, uint x);

        public StudentController(UserManager<AppUser> userManager, AppDbContext context, StudentService studentService)
        {
            _userManager = userManager;
            _context = context;
            _studentService = studentService;
        }

        [HttpGet("GetMyGroup")]
        public async Task<IActionResult> GetMyGroup()
            => Ok(_studentService.GetMyGroup(User));

        [HttpGet("GetGroupTeachers")]
        public List<AppUser> GetGroupTeachers(ERole role) 
            => _studentService.GetGroupUsers(User, role);

        [HttpGet($"GetStudentMarksFor X days")]
        public async Task<List<Mark>> GetStudentMarksForXdays(Guid id, uint x, EMarkType markType)
            => await _studentService.GetStudentMarksForLastXdays(id, User, x, markType);
    }

}
