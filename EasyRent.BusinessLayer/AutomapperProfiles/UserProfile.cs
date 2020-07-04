using AutoMapper;
using EasyRent.BusinessLayer.Models;
using EasyRent.Data.Entities;

namespace EasyRent.BusinessLayer.AutomapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<SignInModel, User>();
            CreateMap<SignUpModel, User>();
        }
    }
}