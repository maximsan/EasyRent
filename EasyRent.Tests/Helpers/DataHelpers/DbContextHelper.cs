using EasyRent.Data;
using EasyRent.Data.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

            FillDbSet(context, AdHelper.GetTestAds);
            FillDbSet(context, UserHelper.GetTestUsers);

            FillDbSet(context, FakeData.GetCategories);
            FillDbSet(context, FakeData.GetSubcategories);

            return context;
        }

        private static void FillDbSet<TEntity>(ApplicationDbContext context, Func<IEnumerable<TEntity>> dataFunc) where TEntity : class
        {
            var dbSet = context.Set<TEntity>();

            if (!dbSet.Any())
            {
                lock (locker) // sync all threads
                {
                    if (!dbSet.Any())
                    {
                        var data = dataFunc();

                        foreach (var item in data)
                        {
                            dbSet.Add(item);
                        }

                        context.SaveChanges();
                    }
                }
            }
        }

        private static DbContextOptions<ApplicationDbContext> GetInMemoryOptions()
        {
            return new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("EasyRentDatabase")
                .Options;
        }
    }
}