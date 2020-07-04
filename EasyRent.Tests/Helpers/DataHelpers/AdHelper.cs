using DIMS_Core.Common.Enums;
using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.Common.Extensions;
using EasyRent.Data.Entities;
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
                    AdImages = null,
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
                var query = GetTestAds().AsQueryable();

                if (request.AdId.HasValue)
                {
                    query = query.Where(q => q.AdId == request.AdId.Value);
                }

                query = query.SortAndTake(request.SortExpression, request.Page, request.PageSize, q => q.AdId, SortDirections.ASC);
                var model = TestMapper.Instance.ProjectTo<AdModel>(query, null);

                return model.ToList();
            });
        }
    }
}