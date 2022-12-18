using TalabalarJurnali.Data.Repositories;
using TalabalarJurnali.Teacher.API.Dtos;

namespace TalabalarJurnali.Teacher.API.Services;

public interface ITeacherService
{
    Task<TeacherDto> UpdateTeacherAsync(UpdateTeacherDto updateTeacher);

    Task<StudentStatsOfDays> DefineStudentAttendance(Guid Id);

}