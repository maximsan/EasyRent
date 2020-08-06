using EasyRent.Data;
using EasyRent.Data.Entities;
using EasyRent.Data.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;

namespace EasyRent.Tests.Helpers.DataHelpers
{
    public static class UserHelper
    {
        public static IEnumerable<User> GetTestUsers()
        {
            return FakeData.GetFakeUsers();
        }

        public static UserManager<User> GetUserManager(ApplicationDbContext context)
        {
            var userStore = new UserStore<User, Role, ApplicationDbContext, int>(context);
            var userManager = new UserManager<User>(userStore, null, null, null, null, null, null, null, null);

            return userManager;
        }

        public static SignInManager<User> GetSignInManager(UserManager<User> userManager)
        {
            var httpContext = new DefaultHttpContext();
            var accessor = new Mock<IHttpContextAccessor>();
            var claimsFactory = new Mock<IUserClaimsPrincipalFactory<User>>();

            accessor.SetupGet(q => q.HttpContext).Returns(httpContext);

            return new SignInManager<User>(userManager, accessor.Object, claimsFactory.Object, null, null, null, null);
        }
    }
}