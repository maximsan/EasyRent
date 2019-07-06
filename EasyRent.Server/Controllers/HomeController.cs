using System.Collections.Generic;
using AutoMapper;
using EasyRent.Data;
using EasyRent.Server.Common;
using Microsoft.AspNetCore.Mvc;

namespace EasyRent.Server.Controllers
{
    public class HomeController : BaseController
    {
        private readonly List<string> list = new List<string>
        {
            "Max",
            "Alex",
            "Fedr"
        };

        public HomeController(UnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel
        //    {
        //        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        //    });
        //}

        public IActionResult Index()
        {
            return Json(new JsonResponseTemplate(nameof(HomeController), string.Empty));
        }
    }
}