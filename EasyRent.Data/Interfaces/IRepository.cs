using System.Linq;
using System.Threading.Tasks;

namespace EasyRent.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task CreateAsync(TEntity entity);
        void Delete(TEntity entity);
        void Dispose();
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetByIdAsync(int id);
        Task SaveAsync();
        void Update(TEntity entity);
    }
}