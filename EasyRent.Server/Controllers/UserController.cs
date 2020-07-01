using EasyRent.Common.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyRent.Server.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService) => this.userService = userService;

        [HttpGet]
        public async Task<IActionResult> Address()
        {
            var address = await userService.GetAddressByEmailAsync(User.Identity.Name);

            return OkOrNotFound(address);
        }

        [HttpGet]
        public async Task<IActionResult> Address(int id)
        {
            var address = await userService.GetAddressByIdAsync(id);

            return OkOrNotFound(address);
        }

        [HttpGet]
        public async Task<IActionResult> Bookmarks()
        {
            var bookmarks = await userService.GetBookmarks(User.Identity.Name);

            return OkOrNotFound(bookmarks);
        }
    }
}