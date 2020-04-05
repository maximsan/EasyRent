using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EasyRent.Common.Extentions;
using EasyRent.Common.Models;
using EasyRent.Common.Models.AdModels;
using EasyRent.Data;
using EasyRent.Data.Entities;
using EasyRent.Server.Models;
using EasyRent.Server.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyRent.Server.Controllers
{
    [Authorize]
    public class AdController : BaseController
    {
        private readonly AdService adService;
        public AdController(UnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) {
            adService = new AdService(unitOfWork, mapper);
        }

        [HttpGet]
        public IActionResult Get([FromBody] AdRequest request)
        {
            if(request is null)
            {
                return BadRequest();
            }

            var adsExpression = adService.Search(request);
            var result = Mapper.Map<List<AdViewModel>>(adsExpression);

            return Json(result);
        }

        [HttpPost("[action]")]
        public IActionResult Put([FromBody] AdModel model) // TODO: Change this logic.
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonResponseTemplate(false, GetModelStateErrors()));
            }

            Ad newProduct = Mapper.Map<Ad>(model);

            UnitOfWork.AdRepository.Create(newProduct);
            UnitOfWork.AdRepository.Save();

            return Json(new JsonResponseTemplate(true, string.Empty));
        }
    }
}
