using FBGateway.Services;
using FBSharedLibrary.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FBGateway.Controllers
{
    [ApiController]
    [EnableCors]
    [Route("api/user")]
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

        [HttpPost]
        [Route("newaccount")]
        public async Task<IActionResult> CreateNewAccount([FromBody] UserFull user)
        {
            try
            {
                await _userService.CreateNewAccount(user);
            }
            catch (Exception e)
            {
                if (e.Message == ((int)HttpStatusCode.Conflict).ToString())
                    return Conflict();

                return BadRequest(e.Message);
            }

            return Ok();
        }
    }
}
