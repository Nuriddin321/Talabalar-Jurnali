using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Teacher.API.Dtos;
using ELessonParticipatingStatus = TalabalarJurnali.Data.Entities.ELessonParticipatingStatus;

namespace TalabalarJurnali.Teacher.API.Services;

public interface ITeacherService
{
    Task<TeacherDto> UpdateTeacherAsync(UpdateTeacherDto updateTeacher);

    Task<StudentStatsOfDay> DefineStudentsLessonAttendanceAsync(Guid studentId, ELessonParticipatingStatus status);
}