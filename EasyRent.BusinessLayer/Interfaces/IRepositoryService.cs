using EasyRent.BusinessLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyRent.BusinessLayer.Interfaces
{
    public interface IRepositoryService<TModel, in TRequest> where TRequest : SearchRequest
        where TModel : class, new()
    {
        Task<TModel> GetByIdAsync(int id);

        Task<TModel> CreateAsync(TModel model);

        Task DeleteAsync(int id);

        Task<List<TModel>> SearchAsync(TRequest request);

        Task UpdateAsync(TModel model);
    }
}