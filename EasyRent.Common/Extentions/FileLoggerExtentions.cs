using EasyRent.Common.Logger;
using Microsoft.Extensions.Logging;

namespace EasyRent.Common.Extentions
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
