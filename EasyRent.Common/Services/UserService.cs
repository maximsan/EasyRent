using AutoMapper;
using EasyRent.Common.Extentions;
using EasyRent.Common.Models.UserModels;
using EasyRent.Data;
using EasyRent.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace EasyRent.Common.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly UserManager<User> userManager;

        public UserService(UnitOfWork unitOfWork,
            IMapper mapper,
            UserManager<User> userManager) : base(unitOfWork, mapper) => this.userManager = userManager;

        public async Task<AddressModel> GetAddress(string userName)
        {
            if (userName.IsNullOrWhiteSpace())
            {
                return null;
            }

            var addressEntity = (await userManager.FindByUserNameOrEmailAsync(userName))?.Address;
            var mappedModel = mapper.Map<AddressModel>(addressEntity);

            return mappedModel;
        }
    }
}