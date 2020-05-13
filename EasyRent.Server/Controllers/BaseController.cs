using EasyRent.Common.Extentions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace EasyRent.Server.Controllers
{
    public class BaseController : Controller
    {
        protected T GetService<T>() => HttpContext.RequestServices.GetService<T>();

        protected void SetJsonResponseType() => Response.ContentType = "application/json";
    }
}