using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public interface ITeacherRepository
{
    Task<List<Teacher>> GetAllTeachersAsync();
    Task<Teacher> GetTeacherByIdAsync(Guid id);
    Task CreateTeacherAsync(Teacher adminEntity);
    Task EditTeacherAsync(Teacher adminEntity);
    Task RemoveTeacherAsync(Guid id);
    Task<bool> IsExists(Guid? id);
}
