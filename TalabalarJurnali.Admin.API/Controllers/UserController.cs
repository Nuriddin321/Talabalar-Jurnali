using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalabalarJurnali.Admin.API.Dtos;
using TalabalarJurnali.Admin.API.Services;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Admin.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userServcie;

    public UserController(
        IUserService userServcise)
    {
        _userServcie = userServcise;
    }

    [HttpPost("create")]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> CreateUser([FromForm] CreateUserDto createUserDto)
    {
        var createdUser = await _userServcie.CreateUserAsync(createUserDto);
        if (createUserDto is null)
            return BadRequest();

        return Ok(createdUser);
    }

    [HttpGet("userId")]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetUserById(Guid userId)
    { 
        var user = await _userServcie.GetUserByIdAsync(userId);
        if (user is null)
            return BadRequest();

        return Ok(user);
    }

    [HttpGet("users")]
    [ProducesResponseType(typeof(List<UserDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _userServcie.GetAllUsersAsync();

        return Ok(users);
    }

    [HttpPut("update/userId")]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> UpdateUserById(Guid userid, [FromForm] UpdateUserDto updateUserDto)
    {
        var updatedUser = await _userServcie.UpdateUserAsync(userid, updateUserDto);
        if(updatedUser is null)
            return BadRequest();

        return Ok(updatedUser);
    }

    [HttpDelete("userId")]
    [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
    public async Task<IActionResult> DeleteUserById(Guid userId)
    {
        var isDeleted = await _userServcie.DeleteUserAsync(userId);
        if(isDeleted is false)
            return BadRequest();

        return Ok(true);
    }

    [HttpGet("users-role")]
    [ProducesResponseType(typeof(List<UserDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetUsersByRole(ERole role)
    {
        var users = await _userServcie.GetUsersByRoleAsync(role);
        if (users is null)
            return BadRequest();

        return Ok(users);
    }
}
