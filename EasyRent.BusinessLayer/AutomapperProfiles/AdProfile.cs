using AutoMapper;
using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.Data.Entities;
using EasyRent.Data.Repositories.Filters;

namespace EasyRent.BusinessLayer.AutomapperProfiles
{
    public class AdProfile : Profile
    {
        public AdProfile()
        {
            CreateMap<Ad, AdViewModel>();
            CreateMap<AdRequest, AdFilter>();
            CreateMap<AdModel, Ad>();
        }
    }
}