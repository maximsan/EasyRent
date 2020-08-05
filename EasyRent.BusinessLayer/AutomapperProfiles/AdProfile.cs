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
            CreateMap<AdRequest, AdFilter>();
            CreateMap<Ad, AdModel>().ReverseMap();
            CreateMap<Image, ImageModel>();
        }
    }
}