using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRent.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace EasyRent.Server.Common.Extentions
{
    public static class UserManagerExtentions
    {
        public static T FindByUserNameOrEmail<T>(this UserManager<T> userManager, string userNameOrEmail) where T : User
        {
            return userManager.Users.FirstOrDefault(q => q.UserName == userNameOrEmail || q.Email == userNameOrEmail);
        }
    }
}
