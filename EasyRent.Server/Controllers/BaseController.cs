using Microsoft.AspNetCore.Mvc;

namespace EasyRent.Server.Controllers
{
    public class BaseController : Controller
    {
        [NonAction]
        protected IActionResult OkOrNotFound(object obj) => obj is null ? NotFound() : (IActionResult)Ok(obj);
    }
}