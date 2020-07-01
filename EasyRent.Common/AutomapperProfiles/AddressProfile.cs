using AutoMapper;
using EasyRent.Common.Models.UserModels;
using EasyRent.Data.Entities;

namespace EasyRent.Common.AutomapperProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressModel>();
        }
    }
}