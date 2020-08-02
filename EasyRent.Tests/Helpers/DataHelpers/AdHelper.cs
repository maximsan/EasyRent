using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.Common.Extensions;
using EasyRent.Data.Entities;
using EasyRent.Data.Helpers;
using EasyRent.Data.Repositories.Filters;
using EasyRent.Tests.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyRent.Tests.Helpers.DataHelpers
{
    public static class AdHelper
    {
        public static IEnumerable<Ad> GetTestAds()
        {
            var fakeDate = FakeData.GetFakeAds();

            return fakeDate;
        }

        public static IEnumerable<Ad> GetTestAdDbSet()
        {
            var data = GetTestAds();

            return data;
        }

        public static Task<List<AdModel>> Search(AdRequest request)
        {
            return Task.Run(() =>
            {
                var filter = TestMapper.Instance.Map<AdFilter>(request);

                var query = Search(filter);
                var model = TestMapper.Instance.ProjectTo<AdModel>(query, null);

                return model.ToList();
            });
        }

        public static IQueryable<Ad> Search(AdFilter filter)
        {
            var query = GetTestAds().AsQueryable();

            if (filter.AdId.HasValue)
            {
                query = query.Where(q => q.AdId == filter.AdId.Value);
            }

            query = query.SortAndTake(filter.SortExpression, filter.Page, filter.PageSize);

            return query;
        }
    }
}