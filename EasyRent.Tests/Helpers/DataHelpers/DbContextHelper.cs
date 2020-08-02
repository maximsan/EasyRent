using EasyRent.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EasyRent.Tests.Helpers.DataHelpers
{
    public class DbContextHelper
    {
        public static async Task<ApplicationDbContext> GetTestDbContextAsync()
        {
            var data = AdHelper.GetTestAdDbSet();
            var options = GetInMemoryOptions();

            var context = new ApplicationDbContext(options);

            foreach (var item in data)
            {
                await context.Ads.AddAsync(item);
            }

            await context.SaveChangesAsync();

            return context;
        }

        public static ApplicationDbContext GetTestDbContext()
        {
            var data = AdHelper.GetTestAdDbSet();
            var options = GetInMemoryOptions();

            var context = new ApplicationDbContext(options);

            foreach (var item in data)
            {
                context.Ads.Add(item);
            }

            context.SaveChanges();

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