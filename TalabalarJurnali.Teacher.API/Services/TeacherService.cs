using Microsoft.AspNetCore.Identity;
using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Data.Repositories;
using TalabalarJurnali.Teacher.API.Dtos;

namespace TalabalarJurnali.Teacher.API.Services;

public class TeacherService : ITeacherService
{
    private readonly UserRepository _userRepository;
    private readonly UserManager<AppUser> _userManager;

    public TeacherService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<StudentStatsOfDays> DefineStudentAttendance(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherDto> UpdateTeacherAsync(UpdateTeacherDto updateTeacher)
    {
        throw new NotImplementedException();
    }
}