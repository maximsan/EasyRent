using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRent.Server.Controllers
{
    public class BaseController : Controller
    {
        protected T GetService<T>() => HttpContext.RequestServices.GetService<T>();

        protected void SetJsonResponseType() => Response.ContentType = "application/json";
    }
}