using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Data.Repositories;

public interface IUserRepository
{
    Task<AppUser> GetUserByIdAsync(Guid userId);
    Task<AppUser> GetUserByUserNameAsync(string username);
    Task<AppUser> GetUserByEmailAsync(string email);
    Task<List<AppUser>> GetAllUserByRoleIdAsync(string role);
    Task<AppUser> UpdateUsetAsync(AppUser user);
    Task<AppUser> CreateUserAsync(AppUser user);
    Task DeleteUserAsync(AppUser user);
}
