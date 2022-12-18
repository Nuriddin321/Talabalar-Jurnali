using Mapster;
using Microsoft.AspNetCore.Identity;
using TalabalarJurnali.Admin.API.Dtos;
using TalabalarJurnali.Data.Entities;
using TalabalarJurnali.Data.Repositories;

namespace TalabalarJurnali.Admin.API.Services;

public class AccountService : IAccountService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly IFileHelper _fileHelper;
    private readonly IAccountRepository _accountRepository;

    public AccountService(
        UserManager<AppUser> userManager,
        SignInManager<AppUser> signInManager,
        IFileHelper fileHelper,
        IAccountRepository accountRepository)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _fileHelper = fileHelper;
        _accountRepository = accountRepository;
    }

    public async Task<UserDto?> LoginAsync(Login loginDto)
    {

        if (string.IsNullOrWhiteSpace(loginDto.UserName))
            return null;

        if (string.IsNullOrWhiteSpace(loginDto.Password))
            return null;

        var loginResult = await _signInManager.PasswordSignInAsync(loginDto.UserName, loginDto.Password, true, true);
        if (!loginResult.Succeeded)
            return null;

        var user = await _accountRepository.GetUserByUserName(loginDto.UserName);
        if (user is null)
            return null;

        return user.Adapt<UserDto>();
    }

    public async Task<UserDto?> RegisterAsync(Register regitserDto)
    {
        if(string.IsNullOrWhiteSpace(regitserDto.FirstName))
            return null;

        if (string.IsNullOrWhiteSpace(regitserDto.UserName))
            return null;

        if (string.IsNullOrWhiteSpace(regitserDto.Email))
            return null;

        if (regitserDto.Password != regitserDto.ConfirmPassword)
            return null;

        if (await _accountRepository.GetUserByUserName(regitserDto.UserName) is not null)
            return null;

        var user = regitserDto.Adapt<AppUser>();
        if (user.AvatarUrl is not null)
            user.AvatarUrl = await _fileHelper.SaveFileAsync(regitserDto.Avatar, EFileType.Images, EFileFolder.User);

        var registerResult = await _userManager.CreateAsync(user, regitserDto.Password);
        if (!registerResult.Succeeded)
            return null;

        await _signInManager.SignInAsync(user, true);

        return user.Adapt<UserDto>();
    }
}
