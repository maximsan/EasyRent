using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyRent.Server.Controllers
{
    [Authorize]
    public class AuthorizedController : BaseController
    {
        [NonAction]
        protected string GetUserName()
        {
            return User.Identity.Name;
        }
    }
}