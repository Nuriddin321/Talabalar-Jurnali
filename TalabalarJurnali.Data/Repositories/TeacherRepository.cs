namespace TalabalarJurnali.Data.Repositories;

public class TeacherRepository : ITeacherRepository
{
    public Task CreateTeacherAsync(Teacher adminEntity)
    {
        throw new NotImplementedException();
    }

    public Task EditTeacherAsync(Teacher adminEntity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Teacher>> GetAllTeacherAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Teacher> GetTeacherByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsExists(Guid? id)
    {
        throw new NotImplementedException();
    }

    public Task RemoveTeacherAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
