using TalabalarJurnali.Admin.API.Dtos;

namespace TalabalarJurnali.Admin.API.Services;

public interface IAccountService
{
    Task<UserDto> RegisterAsync(Register regitserDto);
    Task<UserDto> LoginAsync(Login loginDto);
}
