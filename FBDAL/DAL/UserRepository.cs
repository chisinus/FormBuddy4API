using FBDAL.Context;
using FBDAL.Entities;
using FBSharedLibrary;
using FBSharedLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace FBDAL.DAL
{
    public class UserRepository : IUserRepository
    {
        private FormBuddyContext context;

        public UserRepository(FormBuddyContext context)
        {
            this.context = context;
        }
        public async Task<UserBasic> Login(string username, string password)
        {
            throw new Exception("123");
        }

        public async Task CreateUserAccount(UserFull user)
        {
            if (await UsernameExists(user.Username))
                throw new Exception(((int)(HttpStatusCode.Conflict)).ToString());

            context.TblUsers.Add(
                new TblUser
                {
                    Lastname = user.Lastname,
                    Firstname = user.Firstname,
                    Username = user.Username,
                    Password = user.Password,
                    PasswordSand = "",
                    GenderTypeId = user.GenderId,
                    StatusId = (int)FBConstants.AccountStaus.Active,
                    SecurityQuestionId = user.SecurityQuestionID,
                    SecurityQuestionAnswer = user.SecurityQuestionAnswer,
                    CurrentGroupId = 0,
                    Dob = user.Dob
                });

            await context.SaveChangesAsync();
        }

        private async Task<bool> UsernameExists(string username)
        {
            var user = await context.TblUsers.Where(u => u.Username == username).FirstOrDefaultAsync();

            return user != null;
        }
    }
}
