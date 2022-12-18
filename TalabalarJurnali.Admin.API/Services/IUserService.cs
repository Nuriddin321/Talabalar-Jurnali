using TalabalarJurnali.Admin.API.Dtos;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Admin.API.Services;

public interface IUserService
{
    Task<UserDto> CreateUserAsync(CreateUserDto createUser);
    Task<UserDto> UpdateUserAsync(Guid id, UpdateUserDto updateUser);
    Task<bool> DeleteUserAsync(Guid id);
    Task<List<UserDto>> GetAllUsersAsync();
    Task<List<UserDto>> GetUsersByRoleAsync(ERole eRole);
    Task<UserDto> GetUserByIdAsync(Guid id);
}
