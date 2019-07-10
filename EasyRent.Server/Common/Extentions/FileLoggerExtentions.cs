using EasyRent.Server.Common.Logger;
using Microsoft.Extensions.Logging;

namespace EasyRent.Server.Common.Extentions
{
    public static class FileLoggerExtentions
    {
        public static ILoggerFactory AddFileLogger(this ILoggerFactory loggerFactory)
        {
            loggerFactory.AddProvider(new FileLoggerProvider());
            loggerFactory.CreateLogger("FileLogger");

            return loggerFactory;
        }
    }
}
