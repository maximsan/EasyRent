using EasyRent.Data;
using EasyRent.Data.Interfaces;
using EasyRent.Tests.Helpers.DataHelpers;
using System;

namespace EasyRent.Tests.Common.Fixtures
{
    public class UnitOfIssueFixture : IDisposable
    {
        public IUnitOfWork UnitOfWork { get; set; }

        public UnitOfIssueFixture()
        {
            var dbContext = DbContextHelper.GetTestDbContext();
            UnitOfWork = new UnitOfWork(dbContext);
        }

        public void Dispose()
        {
            UnitOfWork.Dispose();
        }
    }
}