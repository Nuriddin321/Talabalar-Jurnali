using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Data.Repositories;
using TalabalarJurnali.Teacher.API.Dtos;

namespace TalabalarJurnali.Teacher.API.Services;

public interface ITeacherService
{
    Task<TeacherDto> UpdateTeacherAsync(UpdateTeacherDto updateTeacher);

    Task<StudentStatsOfDay> DefineStudentAttendance(Guid studentId, ELessonParticipatingStatus status);
}