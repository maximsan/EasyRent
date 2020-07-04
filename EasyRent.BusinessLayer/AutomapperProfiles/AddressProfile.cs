using AutoMapper;
using EasyRent.BusinessLayer.Models.UserModels;
using EasyRent.Data.Entities;

namespace EasyRent.BusinessLayer.AutomapperProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressModel>();
        }
    }
}