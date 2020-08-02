using EasyRent.Data;
using EasyRent.Tests.Helpers.DataHelpers;
using System;

namespace EasyRent.Tests.Common.Fixtures
{
    public class ApplicationDbContextFixture : IDisposable
    {
        public ApplicationDbContext DbContext { get; }

        public ApplicationDbContextFixture()
        {
            DbContext = DbContextHelper.GetTestDbContext();
        }

        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}