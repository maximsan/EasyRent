using AutoMapper;
using EasyRent.BusinessLayer.Interfaces;
using EasyRent.BusinessLayer.Models;
using EasyRent.BusinessLayer.Models.UserModels;
using EasyRent.Common.Extensions;
using EasyRent.Data.Entities;
using EasyRent.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace EasyRent.BusinessLayer.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public UserService(
            IUnitOfWork unitOfWork,
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
            var mappedModel = _mapper.Map<AddressModel>(addressEntity);

            return mappedModel;
        }

        public async Task<AddressModel> GetAddressByIdAsync(int userId)
        {
            if (userId <= 0)
            {
                return null;
            }

            var addressEntity = (await FindByIdAsync(userId).ConfigureAwait(false))?.Address;
            var mappedModel = _mapper.Map<AddressModel>(addressEntity);

            return mappedModel;
        }

        public async Task<SignInResult> SignInAsync(SignInModel model)
        {
            var user = await FindByUserNameOrEmailAsync(model.Email);

            if (user is null)
            {
                return SignInResult.Failed;
            }

            var signInStatus = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false).ConfigureAwait(false);

            return signInStatus;
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            var mappedUser = _mapper.Map<User>(model);

            var signUpStatus = await userManager.CreateAsync(mappedUser, model.Password).ConfigureAwait(false);

            return signUpStatus;
        }

        public async Task SignOutAsync()
        {
            await signInManager.SignOutAsync();
        }

        public async Task<BookmarkListModel> GetBookmarksAsync(string email)
        {
            var entity = await FindByUserNameOrEmailAsync(email);
            var mappedEntity = _mapper.Map<BookmarkListModel>(entity?.BookmarkList);

            return mappedEntity;
        }

        public async Task<ProfileModel> GetProfileAsync(string email)
        {
            var entity = await FindByUserNameOrEmailAsync(email);
            var mappedEntity = _mapper.Map<ProfileModel>(entity);

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