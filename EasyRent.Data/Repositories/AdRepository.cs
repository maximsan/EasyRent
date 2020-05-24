using EasyRent.Data.Entities;
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
                query.Where(q => q.AdId == filter.AdId.Value);
            }

            if (filter.PageSize > 0)
            {
                query.Skip(filter.Page * filter.PageSize)
                    .Take(filter.PageSize);
            }

            #endregion Filtering

            if (!string.IsNullOrWhiteSpace(filter.SortExpression))
            {
                query.OrderBy(filter.SortExpression);
            }

            return query;
        }
    }
}