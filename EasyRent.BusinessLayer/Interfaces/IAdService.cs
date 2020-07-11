using EasyRent.BusinessLayer.Models.AdModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyRent.BusinessLayer.Interfaces
{
    public interface IAdService
    {
        Task CreateAsync(AdModel model);
        Task DeleteAsync(int id);
        Task<List<AdModel>> SearchAsync(AdRequest request);
        Task UpdateAsync(AdModel model);
    }
}