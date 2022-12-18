using Microsoft.AspNetCore.Mvc;
using TalabalarJurnali.Admin.API.Dtos;
using TalabalarJurnali.Admin.API.Services;

namespace TalabalarJurnali.Student.API.Controllers
{
    public class AccountController : ControllerBase
     {
            private readonly IAccountService _accountService;

            public AccountController(IAccountService accountService)
            {
                _accountService = accountService;
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
}