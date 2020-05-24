using EasyRent.Data.Entities;
using EasyRent.Data.Repositories.Filters;
using System.Linq;

namespace EasyRent.Data.Repositories
{
    public interface IAdRepository : IRepository<Ad>
    {
        IQueryable<Ad> Search(AdFilter filter);
    }
}