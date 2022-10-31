using FBSharedLibrary.Models;

namespace FBUserApi.Services
{
    public class UserService: IUserService
    {
        public async Task<UserBasic> GetUserByUsernamePassword(string username, string password)
        {
            UserBasic result = new UserBasic()
            {
                UserName = "username",
                Firstname = "firstname",
                Lastname = "lasname"
            };

            return result;
        }
    }
}
