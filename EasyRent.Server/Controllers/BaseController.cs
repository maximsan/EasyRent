using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRent.Server.Controllers
{
    public class BaseController : Controller
    {
        protected IActionResult OkOrNotFound(object obj) => obj is null ? NotFound() : (IActionResult)Ok(obj);
    }
}