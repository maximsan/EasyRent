using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyPeasyRent.Common;
using Microsoft.Extensions.Logging;

namespace EasyPeasyRent
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
