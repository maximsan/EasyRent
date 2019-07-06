using System;
using Microsoft.Extensions.Logging;

namespace EasyRent.Server.Common.Logger
{
    public class FileLoggerProvider : ILoggerProvider
    {
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!disposed)
                {
                    disposed = true;
                }
            }
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger();
        }
    }
}
