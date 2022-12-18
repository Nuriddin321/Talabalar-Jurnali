using TalabalarJurnali.Teacher.API.Dtos;

namespace TalabalarJurnali.Teacher.API.Services;

public class TeacherService : ITeacherService
{
    private readonly UserRepository _userRepository;

    public TeacherService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<TeacherDto> CreateTeacherAsync(CreateTeacherDto teacherDto)
    {
        throw new NotImplementedException();
    }

    public Task<List<TeacherDto>> GetAllTeachersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TeacherDto> GetTeacherByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTeacherAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherDto> UpdateTeacherAsync(UpdateTeacherDto updateTeacher)
    {
        throw new NotImplementedException();
    }
}