using Mapster;
using Microsoft.AspNetCore.Identity;
using TalabalarJurnali.Admin.API.Dtos;
using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Data.Repositories;

namespace TalabalarJurnali.Admin.API.Services;

public class UserServcise : IUserServcise
{
    private readonly IUserRepository _userRepository;
    private readonly IFileHelper _fileHelper;

    public UserServcise(
        IUserRepository userRepository,
        IFileHelper fileHelper)
    {
        _userRepository = userRepository;
        _fileHelper = fileHelper;
    }

    public async Task<UserDto> CreateUserAsync(CreateUserDto createUser)
    {
        if (string.IsNullOrWhiteSpace(createUser.FirstName))
            return null;

        if (createUser.Password != createUser.ConfirmPassword)
            return null;

        PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();

        var user = new AppUser()
        {
            FirstName = createUser.FirstName,
            LastName = createUser.LastName,
            Email = createUser.Email,
            UserName = createUser.Username,
            PhoneNumber = createUser.PhoneNumber,
            UserRole = createUser.Role,
        };
        user.PasswordHash = passwordHasher.HashPassword(user, createUser.Password);
        if (createUser.AvatarUrl is not null)
            user.AvatarUrl = await _fileHelper.SaveFileAsync(createUser.AvatarUrl, EFileType.Images, EFileFolder.User);

        var createdUSer = await _userRepository.CreateUserAsync(user);
        if (createdUSer is null)
            return null;

        return user.Adapt<UserDto>();
    }

    public async Task<bool> DeleteUserAsync(Guid id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        if (user is null)
            return false;

        await _userRepository.DeleteUserAsync(user);

        return true;
    }

    public async Task<List<UserDto>> GetAllUsersAsync()
    {
        var users = await _userRepository.GetAllUsers();

        return users.Select(user => user.Adapt<UserDto>()).ToList();
    }

    public async Task<UserDto?> GetUserByIdAsync(Guid id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        if (user is null)
            return null;

        return user.Adapt<UserDto>();
    }
   
    public async Task<List<UserDto>> GetUsersByRoleAsync(ERole eRole)
    {
        var users = await _userRepository.GetAllUserByRoleIdAsync(eRole.ToString());

        return users.Select(user => user.Adapt<UserDto>()).ToList();
    }

    public async Task<UserDto> UpdateUserAsync(Guid id, UpdateUserDto updateUser)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        if (user is null)
            return null;

        user.FirstName = updateUser.FirstName ?? user.FirstName;
        user.LastName = updateUser.LastName ?? user.LastName;
        user.PhoneNumber = updateUser.PhoneNumber ?? user.PhoneNumber ;

        if(updateUser.AvatarUrl != null)
            user.AvatarUrl = await _fileHelper.SaveFileAsync(updateUser.AvatarUrl, EFileType.Images, EFileFolder.User);

        return user.Adapt<UserDto>();
    }
}
