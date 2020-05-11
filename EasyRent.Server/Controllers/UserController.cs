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
            var address = await userService.GetAddress(User.Identity.Name);

            return address is null
                ? NotFound()
                : (IActionResult)Ok(address);
        }
    }
}