using TalabalarJurnali.Teacher.API.Dtos;

namespace TalabalarJurnali.Teacher.API.Services;

public interface ITeacherService
{
    Task<TeacherDto> CreateTeacherAsync(CreateTeacherDto teacherDto);
    Task<TeacherDto> UpdateTeacherAsync(UpdateTeacherDto updateTeacher);
    Task<List<TeacherDto>> GetAllTeachersAsync();
    Task<TeacherDto> GetTeacherByIdAsync(Guid id);
    Task DeleteTeacherAsync(Guid id);
}