using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRent.IdentityServer.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IMapper Mapper;

        public BaseController(IMapper mapper)
        {
            Mapper = mapper;
        }

        protected T GetService<T>() => HttpContext.RequestServices.GetService<T>();

        protected void SetJsonResponseType() => Response.ContentType = "application/json";
    }
}