using DIMS_Core.Common.Enums;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace EasyRent.Common.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> DynamicSort<T>(this IQueryable<T> query,
            string sortExpression)
        {
            query = query.OrderBy(sortExpression);

            return query;
        }

        public static IQueryable<T> SkipAndTake<T>(this IQueryable<T> query,
            int page,
            int pageSize)
        {
            if (pageSize > 0)
            {
                query = query.Skip(pageSize * page)
                    .Take(pageSize);
            }

            return query;
        }

        public static IQueryable<T> SortAndTake<T>(this IQueryable<T> query,
            string sortExpression,
            int page,
            int pageSize)
        {
            return query.DynamicSort(sortExpression)
                .SkipAndTake(page, pageSize);
        }
    }
}