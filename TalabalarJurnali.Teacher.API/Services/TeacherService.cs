using TalabalarJurnali.Data.Repositories;
using TalabalarJurnali.Teacher.API.Dtos;

namespace TalabalarJurnali.Teacher.API.Services;

public class TeacherService : ITeacherService
{
    private readonly UserRepository _userRepository;

    public TeacherService(UserRepository userRepository)
    {
        _userRepository = userRepository;
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