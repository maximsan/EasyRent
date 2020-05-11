using EasyRent.Common.Models.UserModels;
using System.Threading.Tasks;

namespace EasyRent.Common.Services
{
    public interface IUserService
    {
        Task<AddressModel> GetAddress(string userName);
    }
}