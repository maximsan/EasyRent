using EasyRent.Common.Extensions;
using EasyRent.Data.Entities;
using EasyRent.Data.Interfaces;
using EasyRent.Data.Repositories.Filters;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace EasyRent.Data.Repositories
{
    public class AdRepository : BaseRepository<Ad>, IAdRepository
    {
        public AdRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IQueryable<Ad> Search(AdFilter filter)
        {
            var query = GetAll();

            #region Filtering

            if (filter.AdId.HasValue)
            {
                query = query.Where(q => q.AdId == filter.AdId.Value);
            }

            #endregion Filtering

            query = query.SortAndTake(filter.SortExpression, filter.Page, filter.PageSize);

            return query;
        }
    }
}