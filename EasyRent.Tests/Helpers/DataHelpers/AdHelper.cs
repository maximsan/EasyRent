using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.Data.Entities;
using System.Collections.Generic;
using System.Linq;

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

        //public static IEnumerable<AdViewModel> Search(AdRequest request)
        //{
        //    var query = GetTestAds().AsQueryable();

        //    return query.ToList();
        //}
    }
}