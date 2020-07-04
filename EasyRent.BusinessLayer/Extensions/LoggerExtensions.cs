using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System.IO;

namespace EasyRent.BusinessLayer.Extensions
{
    public static class LoggerExtensions
    {
        public static void ConfigureNlogByJson(this ILoggingBuilder logging)
        {
            logging.ClearProviders();
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("nlogconfig.json")
                .Build();

            logging.AddNLog(new NLogLoggingConfiguration(config.GetSection("Nlog")));
        }
    }
}