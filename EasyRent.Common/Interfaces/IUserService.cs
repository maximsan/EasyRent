using EasyRent.Common.Models;
using EasyRent.Common.Models.UserModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace EasyRent.Common.Interfaces
{
    public interface IUserService
    {
        Task<AddressModel> GetAddressByEmailAsync(string email);

        Task<AddressModel> GetAddressByIdAsync(int userId);

        Task<SignInResult> SignInAsync(SignInModel model);

        Task<IdentityResult> SignUpAsync(SignUpModel model);

        Task SignOutAsync();

        Task<BookmarkListModel> GetBookmarks(string email);
    }
}