using System;
using System.IO;
using Microsoft.Extensions.Logging;

namespace EasyRent.Common.Logger
{
    public class FileLogger : ILogger
    {
        private const string rootCatalog = "logger";
        private readonly object locker = new object();

        public FileLogger()
        {
            CreateCatalogIfNotExist();
        }

        public void Log<TState>(LogLevel logLevel,
                                EventId eventId,
                                TState state,
                                Exception exception,
                                Func<TState, Exception, string> formatter)
        {
            CreateFileIfNotExist();

            if (formatter != null)
            {
                lock (locker)
                {
                    try
                    {
                        File.AppendAllText(GetFullFilePath(), formatter(state, exception) + Environment.NewLine);
                    }
                    catch { }
                }
            }
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        private void CreateCatalogIfNotExist()
        {
            lock (locker)
            {
                string fullPathRoot = GetFullCatalogPath();

                try
                {
                    if (!Directory.Exists(fullPathRoot))
                    {
                        Directory.CreateDirectory(fullPathRoot);
                    }
                }
                catch { }
            }
        }

        private void CreateFileIfNotExist()
        {
            lock (locker)
            {
                string pathToFile = GetFullFilePath();

                try
                {
                    if (!File.Exists(pathToFile))
                    {
                        using (File.Create(pathToFile)) { }
                    }
                }
                catch { }
            }
        }

        private static string GetFullCatalogPath()
        {
            return Path.Combine(Environment.CurrentDirectory, rootCatalog);
        }

        private static string GetFullFilePath()
        {
            return Path.Combine(GetFullCatalogPath(), DateTime.Now.ToShortDateString() + ".txt");
        }
    }
}