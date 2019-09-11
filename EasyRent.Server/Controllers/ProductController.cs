using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EasyRent.Data;
using EasyRent.Data.Entities;
using EasyRent.Server.Common;
using Microsoft.AspNetCore.Mvc;

namespace EasyRent.Server.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class ProductController : BaseController
    {
        public ProductController(UnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        [HttpPost]
        public IActionResult GetProducts()
        {
            return Json(new JsonResponseTemplate<IEnumerable<Ad>>(UnitOfWork.AdRepository.GetAll(), string.Empty));
        }

        [HttpPost]
        public IActionResult GetProducts(string title)
        {
            return Json(new JsonResponseTemplate<IEnumerable<Ad>>(UnitOfWork.AdRepository.GetAll().Where(q => q.Title.Contains(title)), string.Empty));
        }
    }
}
