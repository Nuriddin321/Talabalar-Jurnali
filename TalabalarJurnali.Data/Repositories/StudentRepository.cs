namespace TalabalarJurnali.Data.Repositories;

public class StudentRepository : IStudentRepository
{
    public Task CreateStudentAsync(Student adminEntity)
    {
        throw new NotImplementedException();
    }

    public Task EditStudentAsync(Student adminEntity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Student>> GetAllStudentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Student> GetStudentByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsExists(Guid? id)
    {
        throw new NotImplementedException();
    }

    public Task RemoveStudentAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
