using AutoMapper;
using EasyRent.Common.Models.AdModels;
using EasyRent.Data.Entities;
using EasyRent.Data.Repositories.Filters;

namespace EasyRent.Common.AutomapperProfiles
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