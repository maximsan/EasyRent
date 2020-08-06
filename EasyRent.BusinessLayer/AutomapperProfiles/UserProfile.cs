using AutoMapper;
using EasyRent.BusinessLayer.Models;
using EasyRent.BusinessLayer.Models.UserModels;
using EasyRent.Data.Entities;

namespace EasyRent.BusinessLayer.AutomapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<SignInModel, User>();
            CreateMap<SignUpModel, User>();
            CreateMap<User, ProfileModel>()
                .ForMember(q => q.UserId, q => q.MapFrom(w => w.Id));
        }
    }
}