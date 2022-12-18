using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TalabalarJurnali.Data.Data;
using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Data.Repositories;
using TalabalarJurnali.Teacher.API.Dtos;
using ELessonParticipatingStatus = TalabalarJurnali.Data.Entities.ELessonParticipatingStatus;

namespace TalabalarJurnali.Teacher.API.Services;

public class TeacherService : ITeacherService
{
    private readonly UserRepository _userRepository;
    private readonly AppDbContext _context;
    private readonly UserManager<AppUser> _userManager;

    public TeacherService(UserRepository userRepository, AppDbContext context)
    {
        _userRepository = userRepository;
        _context = context;
    }

    public async Task<StudentStatsOfDay> DefineStudentsLessonAttendanceAsync(Guid studentId, ELessonParticipatingStatus status)
    {
        var TodaysStudentStats = await _context.StudentStatsOfDays.FirstOrDefaultAsync(s => s.StudentId == studentId && s.StudyDay.Date == DateTime.Today);
        if (TodaysStudentStats == null)
            return null;

        TodaysStudentStats.LessonParticipatingStatus = status;
        return TodaysStudentStats;
    }

    public Task<TeacherDto> UpdateTeacherAsync(UpdateTeacherDto updateTeacher)
    {
        throw new NotImplementedException();
    }
}