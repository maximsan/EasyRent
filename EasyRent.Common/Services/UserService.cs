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

        public async Task<AddressModel> GetAddressByEmailAsync(string email)
        {
            if (email.IsNullOrWhiteSpace())
            {
                return null;
            }

            var addressEntity = (await FindByUserNameOrEmailAsync(email).ConfigureAwait(false))?.Address;
            var mappedModel = mapper.Map<AddressModel>(addressEntity);

            return mappedModel;
        }

        public async Task<AddressModel> GetAddressByIdAsync(int userId)
        {
            if (userId <= 0)
            {
                return null;
            }

            var addressEntity = (await FindByIdAsync(userId).ConfigureAwait(false))?.Address;
            var mappedModel = mapper.Map<AddressModel>(addressEntity);

            return mappedModel;
        }

        public async Task<SignInResult> SignInAsync(SignInModel model)
        {
            var user = await FindByUserNameOrEmailAsync(model.Email);

            if (user is null)
            {
                return SignInResult.Failed;
            }

            var signInStatus = await signInManager.PasswordSignInAsync(user, model.Password, false, false).ConfigureAwait(false);

            return signInStatus;
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            var mappedUser = mapper.Map<User>(model);

            var signUpStatus = await userManager.CreateAsync(mappedUser, model.Password).ConfigureAwait(false);

            return signUpStatus;
        }

        public async Task SignOutAsync()
        {
            await signInManager.SignOutAsync();
        }

        public async Task<BookmarkListModel> GetBookmarks(string email)
        {
            var entity = await FindByUserNameOrEmailAsync(email);
            var mappedEntity = mapper.Map<BookmarkListModel>(entity?.BookmarkList);

            return mappedEntity;
        }

        #region Private methods

        private async Task<User> FindByUserNameOrEmailAsync(string userNameOrEmail)
        {
            return await userManager.FindByUserNameOrEmailAsync(userNameOrEmail).ConfigureAwait(false);
        }

        private async Task<User> FindByIdAsync(int userId)
        {
            return await userManager.FindByIdAsync(userId.ToString()).ConfigureAwait(false);
        }

        #endregion Private methods
    }
}