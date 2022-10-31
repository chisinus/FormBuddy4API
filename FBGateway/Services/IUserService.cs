using FBSharedLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace FBGateway.Services
{
    public interface IUserService
    {
        public Task<UserBasic> Login(string username, string password);
    }
}
