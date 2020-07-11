using EasyRent.BusinessLayer.Models;
using EasyRent.BusinessLayer.Models.UserModels;
using Microsoft.AspNetCore.Identity;
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
    }
}