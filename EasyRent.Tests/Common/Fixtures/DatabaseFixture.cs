using EasyRent.Data;
using EasyRent.Data.Interfaces;
using EasyRent.Tests.Common.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace EasyRent.Tests.Common.Fixtures
{
    public class DatabaseFixture : IDisposable
    {
        public IUnitOfWork UnitOfWork { get; set; }

        public DatabaseFixture()
        {
            UnitOfWork = new UnitOfWork(new TestApplicationDbContext(new DbContextOptions<ApplicationDbContext>()));
        }

        public void Dispose()
        {
            UnitOfWork.Dispose();
        }
    }
}