using EasyRent.Common.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EasyRent.Server.Controllers
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

        [HttpGet("[action]")]
        public IActionResult Index() => Json(new JsonResponseTemplate(nameof(HomeController), string.Empty));
    }
}