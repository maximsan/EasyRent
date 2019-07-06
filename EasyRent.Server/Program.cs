using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace EasyRent.Server
{
    public class Program
    {
        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                          .UseStartup<Startup>();
        }

        public static void Main(string[] args)
        {
            IWebHost host = CreateWebHostBuilder(args)
                .Build();

            host.Run();
        }
    }
}