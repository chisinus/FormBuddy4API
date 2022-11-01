using FBSharedLibrary.Models;

namespace FBUserApi.Services
{
    public interface IUserService
    {
        Task<UserBasic> GetUserByUsernamePassword(string username, string password);
    }
}
