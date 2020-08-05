using EasyRent.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EasyRent.Tests.Helpers.DataHelpers
{
    public class DbContextHelper
    {
        private static readonly object locker = new object();

        public static ApplicationDbContext GetTestDbContext()
        {
            var options = GetInMemoryOptions();

            var context = new ApplicationDbContext(options);

            if (!context.Ads.Any())
            {
                lock (locker) // sync all threads
                {
                    if (!context.Ads.Any())
                    {
                        var data = AdHelper.GetTestAds();

                        foreach (var item in data)
                        {
                            context.Ads.Add(item);
                        }

                        context.SaveChanges();
                    }
                }
            }

            return context;
        }

        private static DbContextOptions<ApplicationDbContext> GetInMemoryOptions()
        {
            return new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("EasyRentDatabase")
                .Options;
        }
    }
}