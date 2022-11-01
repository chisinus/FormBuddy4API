using FBSharedLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace FBGateway.Services
{
    public interface IUserService
    {
        Task<UserBasic> Login(string username, string password);
        Task CreateNewAccount(UserFull user);
    }
}
