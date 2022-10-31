using FBSharedLibrary.Models;
using FBUserApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FBUserApi.Controllers
{
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetUserByUsernamePassword")]
        public async Task<IActionResult> GetUserByUsernamePassword(string username, string password)
        {
            UserBasic user = await _userService.GetUserByUsernamePassword(username, password);

            return Ok(user);
        }
    }
}
