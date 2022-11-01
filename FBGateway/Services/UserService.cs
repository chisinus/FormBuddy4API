using FBDAL.DAL;
using FBSharedLibrary.Models;
using FBSharedLibrary.Services;
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
            string result = await CallService("url", "api", "data");
            //UserBasic result = new UserBasic()
            //{
            //    UserName = "username",
            //    Firstname = "firstname",
            //    Lastname = "lasname"
            //};

            return JsonConvert.DeserializeObject<UserBasic>(result);
        }

        public async Task CreateNewAccount(UserFull user)
        {
            await userRepository.CreateUserAccount(user);
        }
    }
}
