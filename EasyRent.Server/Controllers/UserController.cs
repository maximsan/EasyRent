using EasyRent.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyRent.Server.Controllers
{
    [Authorize]
    [Route("user")]
    public class UserController : AuthorizedController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) => _userService = userService;

        [HttpGet("address")]
        public async Task<IActionResult> GetAddressAsync()
        {
            var address = await _userService.GetAddressByEmailAsync(GetUserName());

            return OkOrNotFound(address);
        }

        [HttpGet("address/{id:int}")]
        public async Task<IActionResult> GetAddressAsync(int id)
        {
            var address = await _userService.GetAddressByIdAsync(id);

            return OkOrNotFound(address);
        }

        [HttpGet("bookmarks")]
        public async Task<IActionResult> GetBookmarksAsync()
        {
            var bookmarks = await _userService.GetBookmarksAsync(GetUserName());

            return OkOrNotFound(bookmarks);
        }

        [HttpGet("profile")]
        public async Task<IActionResult> GetProfileAsync()
        {
            var result = await _userService.GetProfileAsync(GetUserName());

            return OkOrNotFound(result);
        }
    }
}