using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using EasyRent.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyRent.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : BaseController
    {
        private readonly List<string> list = new List<string>
        {
            "Max",
            "Alex",
            "Fedr"
        };

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel
        //    {
        //        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        //    });
        //}

        [HttpGet("[action]")]
        public IEnumerable<string> Index()
        {
            return list.ToList();
        }
    }
}