using EasyRent.Data;
using EasyRent.Data.Interfaces;
using EasyRent.Tests.Helpers.DataHelpers;
using System;

namespace EasyRent.Tests.Common.Fixtures
{
    public class UnitOfWorkFixture : IDisposable
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public ApplicationDbContext DbContext { get; set; }

        public UnitOfWorkFixture()
        {
            DbContext = DbContextHelper.GetTestDbContext();
            UnitOfWork = new UnitOfWork(DbContext);
        }

        public void Dispose()
        {
            UnitOfWork.Dispose();
        }
    }
}