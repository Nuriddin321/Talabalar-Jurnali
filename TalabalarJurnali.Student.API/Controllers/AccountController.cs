using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TalabalarJurnali.Admin.API.Dtos;
using TalabalarJurnali.Admin.API.Services;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Student.API.Controllers
{
    public class AccountController : ControllerBase
     {
         private readonly UserManager<AppUser> _userManager;
         private readonly SignInManager<AppUser> _signInManager;

         public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
         {
             _userManager = userManager;
             _signInManager = signInManager;
         }

            [HttpPost("Login")]
            public async Task<IActionResult> Login([FromBody] Login loginDto)
            {
                var user = await _userManager.GetUserAsync(User);

                if (user is null)
                    return BadRequest();

                await _signInManager.SignInAsync(user, true, null);

                return Ok(user);
            }

            [HttpPost("LogOut")]
            public async Task<IActionResult> LogOut()
            {
                await _signInManager.SignOutAsync();
                return Ok();
            }

     }
}