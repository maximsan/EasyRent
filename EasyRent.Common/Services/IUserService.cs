using EasyRent.Common.Models;
using EasyRent.Common.Models.UserModels;
using EasyRent.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace EasyRent.Common.Services
{
    public interface IUserService
    {
        Task<AddressModel> GetAddressByEmailAsync(string email);
        Task<AddressModel> GetAddressByIdAsync(string userId);
        Task<SignInResult> SignInAsync(SignInModel model);
        Task<IdentityResult> SignUpAsync(SignUpModel model);
        Task SignOutAsync();
    }
}