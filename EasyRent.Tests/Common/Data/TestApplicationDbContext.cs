using EasyRent.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EasyRent.Tests.Common.Data
{
    public class TestApplicationDbContext : ApplicationDbContext
    {
        public TestApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new TestConfig();
            optionsBuilder.UseNpgsql(config.Configuration.GetConnectionString("MainDatabase"));

            base.OnConfiguring(optionsBuilder);
        }
    }
}