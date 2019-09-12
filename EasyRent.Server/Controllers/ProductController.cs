using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EasyRent.Data;
using EasyRent.Data.Entities;
using EasyRent.Server.Common;
using EasyRent.Server.Models;
using Microsoft.AspNetCore.Authorization;
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

        [HttpPost("[action]")]
        public IActionResult GetProducts([FromBody] string title)
        {
            title = title.Trim();
            title = "%" + title.Replace(' ', '%') + "%";

            return Json(new JsonResponseTemplate<IEnumerable<Ad>>(UnitOfWork.AdRepository.GetAll().Where(q => q.Title.Contains(title)), string.Empty));
        }

        [Authorize]
        [HttpPost("[action]")]
        public IActionResult AddProduct([FromBody] ProductModel productModel)
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonResponseTemplate(false, GetModelStateErrors()));
            }

            Ad newProduct = Mapper.Map<Ad>(productModel);

            UnitOfWork.AdRepository.Create(newProduct);
            UnitOfWork.AdRepository.Save();

            return Json(new JsonResponseTemplate(true, string.Empty));
        }
    }
}
