using DIMS_Core.Common.Enums;
using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.Common.Extensions;
using EasyRent.Data.Entities;
using EasyRent.Data.Repositories.Filters;
using EasyRent.Tests.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyRent.Tests.Helpers.DataHelpers
{
    public static class AdHelper
    {
        public static List<Ad> GetTestAds()
        {
            const int counter = 20;

            var testData = new List<Ad>(counter);

            for (int i = 1; i <= counter; i++)
            {
                var testItem = new Ad
                {
                    AdId = counter,
                    Description = $"Test description {counter}.",
                    Location = $"Test location {counter}.",
                    MaxDays = counter,
                    Price = counter,
                    Title = $"Test title {counter}.",
                    Images = null,
                    UserAds = null,
                    IsGift = (counter % 2) == 0
                };

                testData.Add(testItem);
            }

            return testData;
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

            query = query.SortAndTake(filter.SortExpression, filter.Page, filter.PageSize, q => q.AdId, SortDirections.ASC);

            return query;
        }
    }
}