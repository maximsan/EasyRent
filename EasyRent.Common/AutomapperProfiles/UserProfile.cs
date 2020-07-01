using AutoMapper;
using EasyRent.Common.Models;
using EasyRent.Data.Entities;

namespace EasyRent.Common.AutomapperProfiles
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