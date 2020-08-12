using EasyRent.BusinessLayer.Models;
using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.BusinessLayer.Models.UserModels;
using EasyRent.BusinessLayer.Services.Results;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyRent.BusinessLayer.Interfaces
{
    public interface IUserService
    {
        Task<AddressModel> GetAddressByEmailAsync(string email);

        Task<AddressModel> GetAddressByIdAsync(int userId);

        Task<SignInResult> SignInAsync(SignInModel model);

        Task<IdentityResult> SignUpAsync(SignUpModel model);

        Task SignOutAsync();

        Task<BookmarkListModel> GetBookmarksAsync(string email);
        Task<ProfileModel> GetProfileAsync(string email);
        Task<ResetTokenResult> GetResetPaswordTokenAsync(string email);
        Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model);
        Task<IEnumerable<AdModel>> GetUserAdsAsync(string email);
        Task<IEnumerable<AdModel>> GetUserAdsAsync(int id);
    }
}