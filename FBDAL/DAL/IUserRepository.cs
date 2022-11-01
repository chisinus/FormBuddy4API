using FBSharedLibrary.Models;

namespace FBDAL.DAL
{
    public interface IUserRepository
    {
        Task<UserBasic> Login(string username, string password);
        Task CreateUserAccount(UserFull user);
    }
}
