using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EasyRent.Data;
using IdentityServer4.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRent.Server.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IMapper Mapper;

        public BaseController(IMapper mapper) => Mapper = mapper;

        protected T GetService<T>() => HttpContext.RequestServices.GetService<T>();

        protected void SetJsonResponseType() => Response.ContentType = "application/json";

        protected IEnumerable<string> ModelStateErrors => ModelState.Values.SelectMany(q => q.Errors.Select(w => w.ErrorMessage)
                                                                                                    .Where(w => !w.IsNullOrEmpty()));
    }
}