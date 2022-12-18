using Mapster;
using Microsoft.AspNetCore.Mvc;
using TalabalarJurnali.Admin.API.Dtos;
using TalabalarJurnali.Admin.API.Services;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Admin.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(
        IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromForm] Register regitserDto)
    {
        var user = await _accountService.RegisterAsync(regitserDto);

        if (user is null)
            return BadRequest();
        
        return Ok(user);
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] Login loginDto)
    {
        var user = await _accountService.LoginAsync(loginDto);

        if (user is null)
            return BadRequest();

        return Ok(user);
    }
}