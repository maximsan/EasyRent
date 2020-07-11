using Microsoft.Extensions.Configuration;

namespace EasyRent.Tests.Common
{
    public class TestConfig
    {
        public IConfiguration Configuration { get; }

        public TestConfig()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }
    }
}