using AutoMapper;
using EasyRent.Common.Extentions;
using EasyRent.Common.Models;
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
        private readonly SignInManager<User> signInManager;

        public UserService(UnitOfWork unitOfWork,
            IMapper mapper,
            UserManager<User> userManager,
            SignInManager<User> signInManager) : base(unitOfWork, mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<User> FindAsync(string userNameOrEmail)
        {
            return await userManager.FindByUserNameOrEmailAsync(userNameOrEmail);
        }

        public async Task<AddressModel> GetAddressAsync(string userName)
        {
            if (userName.IsNullOrWhiteSpace())
            {
                return null;
            }

            var addressEntity = (await FindAsync(userName))?.Address;
            var mappedModel = mapper.Map<AddressModel>(addressEntity);

            return mappedModel;
        }

        public async Task<SignInResult> SignInAsync(SignInModel model)
        {
            var user = await FindAsync(model.Email);

            if (user is null)
            {
                return SignInResult.Failed;
            }

            var signInStatus = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

            return signInStatus;
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            var mappedUser = mapper.Map<User>(model);

            var signUpStatus = await userManager.CreateAsync(mappedUser, model.Password);

            return signUpStatus;
        }
    }
}