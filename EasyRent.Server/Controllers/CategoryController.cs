using AutoMapper;
using EasyRent.BusinessLayer.Models.CategoryModels;
using EasyRent.Data.Entities;
using EasyRent.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EasyRent.Server.Controllers
{
    [Route("category")]
    public class CategoryController : BaseController
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public CategoryController(
            IRepository<Category> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("categories")]
        public async Task<IActionResult> GetCategoriesAsync()
        {
            var categories = _repository.GetAll();
            var mappedCategories = _mapper.ProjectTo<CategoryModel>(categories);

            return Ok(await mappedCategories.ToListAsync());
        }
    }
}