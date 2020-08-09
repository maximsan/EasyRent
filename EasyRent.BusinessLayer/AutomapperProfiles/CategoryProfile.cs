using AutoMapper;
using EasyRent.BusinessLayer.Models.CategoryModels;
using EasyRent.Data.Entities;

namespace EasyRent.BusinessLayer.AutomapperProfiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryModel>();
            CreateMap<Subcategory, SubcategoryModel>();
        }
    }
}