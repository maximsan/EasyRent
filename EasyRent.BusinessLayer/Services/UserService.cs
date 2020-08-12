using AutoMapper;
using EasyRent.BusinessLayer.Interfaces;
using EasyRent.BusinessLayer.Models;
using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.BusinessLayer.Models.UserModels;
using EasyRent.BusinessLayer.Services.Results;
using EasyRent.Common.Constants;
using EasyRent.Common.Extensions;
using EasyRent.Data.Entities;
using EasyRent.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyRent.BusinessLayer.Extensions;
using System.Linq;

namespace EasyRent.BusinessLayer.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            UserManager<User> userManager,
            SignInManager<User> signInManager) : base(unitOfWork, mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
            if (model is null)
            {
                return SignInResult.Failed;
            }

            var user = await FindByUserNameOrEmailAsync(model.Email);

            if (user is null)
            {
                return SignInResult.Failed;
            }

            var signInStatus = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false).ConfigureAwait(false);

            return signInStatus;
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            if (model is null)
            {
                return IdentityResult.Failed();
            }

            var mappedUser = _mapper.Map<User>(model);
            var signUpStatus = await _userManager.CreateAsync(mappedUser, model.Password).ConfigureAwait(false);

            return signUpStatus;
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<ResetTokenResult> GetResetPaswordTokenAsync(string email)
        {
            if (email.IsNullOrWhiteSpace())
            {
                return new ResetTokenResult(false);
            }

            var user = await FindByUserNameOrEmailAsync(email);

            if (user is null)
            {
                return new ResetTokenResult(false);
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            return new ResetTokenResult(token.IsNotNullOrWhiteSpace(), token);
        }

        public async Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model)
        {
            var user = await FindByUserNameOrEmailAsync(model.Email);

            if (user is null)
            {
                return IdentityResult.Failed(new IdentityError { Description = ErrorMessages.UserNotExist });
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);

            return result;
        }

        public async Task<BookmarkListModel> GetBookmarksAsync(string email)
        {
            if (email.IsNullOrWhiteSpace())
            {
                return null;
            }

            var entity = await FindByUserNameOrEmailAsync(email);
            var mappedEntity = _mapper.Map<BookmarkListModel>(entity?.BookmarkList);

            return mappedEntity;
        }

        public async Task<ProfileModel> GetProfileAsync(string email)
        {
            if (email.IsNullOrWhiteSpace())
            {
                return null;
            }

            var entity = await FindByUserNameOrEmailAsync(email);
            var mappedEntity = _mapper.Map<ProfileModel>(entity);

            return mappedEntity;
        }

        public async Task<IEnumerable<AdModel>> GetUserAdsAsync(string email)
        {
            if (email.IsNullOrWhiteSpace())
            {
                return Enumerable.Empty<AdModel>();
            }

            var user = await FindByUserNameOrEmailAsync(email);
            var model = GetAdModels(user);

            return model;
        }

        public async Task<IEnumerable<AdModel>> GetUserAdsAsync(int id)
        {
            if (id <= 0)
            {
                return Enumerable.Empty<AdModel>();
            }

            var user = await FindByIdAsync(id);
            var model = GetAdModels(user);

            return model;
        }

        #region Private methods

        private async Task<User> FindByUserNameOrEmailAsync(string userNameOrEmail)
        {
            return await _userManager.FindByUserNameOrEmailAsync(userNameOrEmail).ConfigureAwait(false);
        }

        private async Task<User> FindByIdAsync(int userId)
        {
            return await _userManager.FindByIdAsync(userId.ToString()).ConfigureAwait(false);
        }

        private IEnumerable<AdModel> GetAdModels(User user)
        {
            if (user is null)
            {
                return Enumerable.Empty<AdModel>();
            }

            var mappedAds = _mapper.MapCollection<AdModel>(user.Ads);

            return mappedAds;
        }

        #endregion Private methods
    }
}