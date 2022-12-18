using TalabalarJurnali.Admin.API.Dtos;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Admin.API.Services;

public interface IUserServcie
{
    Task<UserDto> CreateUserAsync(CreateUserDto createUser);
    Task<UserDto> UpdateUserAsync(Guid id, UpdateUserDto updateUser);
    Task<bool> DeleteUserAsync(Guid id);
    Task<List<UserDto>> GetAllUsers();
    Task<List<UserDto>> GetUsersByRole(ERole eRole);
}
