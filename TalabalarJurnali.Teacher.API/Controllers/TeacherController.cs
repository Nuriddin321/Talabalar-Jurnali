using Microsoft.AspNetCore.Mvc;
using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Teacher.API.Dtos;
using TalabalarJurnali.Teacher.API.Services;
using ELessonParticipatingStatus = TalabalarJurnali.Data.Entities.ELessonParticipatingStatus;

namespace TalabalarJurnali.Teacher.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        //Task<UpdateTeacherDto> UpdateTeacherAsync(UpdateTeacherDto updateTeacher);

        //Task<StudentStatsOfDay> DefineStudentsLessonAttendanceAsync(Guid studentId, ELessonParticipatingStatus status);
        private ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpPost("StudentMarking")]
        public async Task<IActionResult> DefineStudentsLessonAttendanceAsync(Guid studentId, ELessonParticipatingStatus status)
        {
            _teacherService.DefineStudentsLessonAttendanceAsync(studentId, status);
            return Ok();
        }

        [HttpPut("UpdateProfile")]
        public async Task<IActionResult> UpdateTeacherAsync(UpdateTeacherDto updateTeacher)
        {
            _teacherService.UpdateTeacherAsync(updateTeacher);
            return Ok();
        }








    }
}
