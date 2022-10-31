using FBSharedLibrary.Models;
using FBSharedLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FBGateway.Services
{
    public class UserService : ServiceBase, IUserService
    {
        public async Task<UserBasic> Login(string username, string password)
        {
            string result = await CallService("url", "api", "data");
            //UserBasic result = new UserBasic()
            //{
            //    UserName = "username",
            //    Firstname = "firstname",
            //    Lastname = "lasname"
            //};

            return JsonConvert.DeserializeObject<UserBasic>(result);
        }
    }
}
