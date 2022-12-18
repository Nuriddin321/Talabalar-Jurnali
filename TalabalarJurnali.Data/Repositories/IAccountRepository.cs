using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public interface IAccountRepository
{
    Task<AppUser> GetUserByUserName(string username);
    Task<AppUser> GetUserByEmail(string email);
    Task<List<AppUser>> GetAllAdminUsers(); 
    Task<List<AppUser>> GetAllTeacherUsers(); 
    Task<List<AppUser>> GetAllStudentUsers();
    Task<AppUser> UpdateUset(AppUser user);
}
