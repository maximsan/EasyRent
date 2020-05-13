using EasyRent.Common.Extentions;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using NLog.Web;
using System;

namespace EasyRent.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "EasyRent.Server";

            CreateWebHostBuilder(args)
                .Build()
                .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging(logging =>
                {
                    logging.ConfigureNlogByJson();
                })
                .UseNLog();
        }
    }
}