using EasyRent.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EasyRent.Common.Extensions
{
    public static class UserManagerExtentions
    {
        public static T FindByUserNameOrEmail<T>(this UserManager<T> userManager, string userNameOrEmail) where T : User
        {
            return userManager.Users.FirstOrDefault(q => q.UserName == userNameOrEmail || q.Email == userNameOrEmail);
        }

        public static async Task<T> FindByUserNameOrEmailAsync<T>(this UserManager<T> userManager, string userNameOrEmail) where T : User
        {
            return await userManager.Users.FirstOrDefaultAsync(q => q.UserName == userNameOrEmail || q.Email == userNameOrEmail).ConfigureAwait(false);
        }
    }
}