using System.Linq;
using System.Threading.Tasks;

namespace EasyRent.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Dispose();
        IQueryable<TEntity> GetAll();
        TEntity GetById(int id);
        Task<TEntity> GetByIdAsync(int id);
        void Save();
        Task SaveAsync();
        void Update(TEntity entity);
    }
}