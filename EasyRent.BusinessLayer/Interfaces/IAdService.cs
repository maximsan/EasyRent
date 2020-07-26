using EasyRent.BusinessLayer.Models.AdModels;

namespace EasyRent.BusinessLayer.Interfaces
{
    public interface IAdService : IRepositoryService<AdModel, AdRequest>
    {
    }
}