using System.Collections.Generic;
using AutoMapper;
using EasyRent.Common.Models;
using EasyRent.Data;
using Microsoft.AspNetCore.Mvc;

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

        public HomeController(UnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        [HttpGet("[action]")]
        public IActionResult Index() => Json(new JsonResponseTemplate(nameof(HomeController), string.Empty));
    }
}