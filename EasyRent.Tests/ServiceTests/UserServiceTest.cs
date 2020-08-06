using EasyRent.BusinessLayer.Interfaces;
using EasyRent.BusinessLayer.Services;
using EasyRent.Tests.Common;
using EasyRent.Tests.Common.Fixtures;
using EasyRent.Tests.Helpers.DataHelpers;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Xunit;

namespace EasyRent.Tests.ServiceTests
{
    public class UserServiceTest : IClassFixture<UnitOfWorkFixture>
    {
        private readonly UnitOfWorkFixture _fixture;
        private readonly IUserService _userService;

        public UserServiceTest(UnitOfWorkFixture fixture)
        {
            _fixture = fixture;

            var userManager = UserHelper.GetUserManager(_fixture.DbContext);
            var signInManager = UserHelper.GetSignInManager(userManager);

            _userService = new UserService(_fixture.UnitOfWork, TestMapper.Instance, userManager, signInManager);
        }

        [Fact]
        public async Task GetProfileAsync()
        {
            var testUser = await _fixture.DbContext.Users.FirstAsync();
            var userProfile = await _userService.GetProfileAsync(testUser.Email);

            Assert.NotNull(userProfile);
            Assert.Equal(testUser.Id, userProfile.UserId);
        }
    }
}