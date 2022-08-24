using FBGateway.Services;
using FBSharedLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace FBGateway.Controllers
{
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            UserBasic user = await _userService.Login(username, password);

            return Ok(user);
        }
    }
}
