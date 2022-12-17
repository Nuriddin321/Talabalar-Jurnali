namespace TalabalarJurnali.Data.Repositories;

public interface IStudentRepository
{
    Task<List<Student>> GetAllStudentsAsync();
    Task<Student> GetStudentByIdAsync(Guid id);
    Task CreateStudentAsync(Student adminEntity);
    Task EditStudentAsync(Student adminEntity);
    Task RemoveStudentAsync(Guid id);
    Task<bool> IsExists(Guid? id);
}
