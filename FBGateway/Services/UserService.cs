using FBDAL.DAL;
using FBSharedLibrary.Models;
using FBSharedLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FBGateway.Services
{
    public class UserService : ServiceBase, IUserService
    {
        private IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<UserBasic> Login(string username, string password)
        {
            //string result = await CallService("url", "api", "data");
            //JsonConvert.DeserializeObject<UserBasic>(result);

            var user = await userRepository.Login(username, password);

            return user;
        }

        public async Task CreateNewAccount(UserFull user)
        {
            await userRepository.CreateUserAccount(user);
        }
    }
}
