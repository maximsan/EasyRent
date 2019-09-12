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
        protected readonly UnitOfWork UnitOfWork;
        protected readonly IMapper Mapper;

        public BaseController(UnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        protected T GetService<T>()
        {
            return HttpContext.RequestServices.GetService<T>();
        }

        protected void SetJsonResponseType()
        {
            Response.ContentType = "application/json";
        }

        protected override void Dispose(bool disposing)
        {
            UnitOfWork.Dispose();
            base.Dispose(disposing);
        }

        protected IEnumerable<string> GetModelStateErrors()
        {
            return ModelState.Values.SelectMany(q => q.Errors.Select(w => w.ErrorMessage)
                                                               .Where(w => !w.IsNullOrEmpty()));
        }
    }
}