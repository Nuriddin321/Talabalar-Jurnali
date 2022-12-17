namespace TalabalarJurnali.Data.Repositories;

public interface ITeacherRepository
{
    Task<List<Teacher>> GetAllTeacherAsync();
    Task<Teacher> GetTeacherByIdAsync(Guid id);
    Task CreateTeacherAsync(Teacher adminEntity);
    Task EditTeacherAsync(Teacher adminEntity);
    Task RemoveTeacherAsync(Guid id);
    Task<bool> IsExists(Guid? id);
}
