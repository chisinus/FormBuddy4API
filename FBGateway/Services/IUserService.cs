using FBSharedLibrary.Models;

namespace FBGateway.Services
{
    public interface IUserService
    {
        Task<UserBasic> Login(string username, string password);
        Task CreateNewAccount(UserFull user);
    }
}
