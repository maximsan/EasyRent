using EasyRent.Data.Entities;
using EasyRent.Data.Helpers;
using System.Collections.Generic;

namespace EasyRent.Tests.Helpers.DataHelpers
{
    public static class AdHelper
    {
        public static IEnumerable<Ad> GetTestAds()
        {
            var fakeDate = FakeData.GetFakeAds();

            return fakeDate;
        }
    }
}