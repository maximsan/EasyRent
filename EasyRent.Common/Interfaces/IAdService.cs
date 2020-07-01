using EasyRent.Common.Models.AdModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyRent.Common.Interfaces
{
    public interface IAdService
    {
        Task Create(AdModel model);
        Task Delete(int id);
        Task<List<AdViewModel>> Search(AdRequest request);
        Task Update(AdModel model);
    }
}