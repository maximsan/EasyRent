using EasyRent.Common.Extentions;
using EasyRent.Common.Models;
using EasyRent.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyRent.Server.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        private readonly UserManager<User> UserManager;

        public UserController(UserManager<User> userManager) => UserManager = userManager;

        [HttpGet]
        public IActionResult GetAddress() => Json(new JsonResponseTemplate<Address>(UserManager.FindByUserNameOrEmail(User.Identity.Name).Address));
    }
}