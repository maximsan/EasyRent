using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.BusinessLayer.Services;
using EasyRent.Data;
using EasyRent.Data.Interfaces;
using EasyRent.Tests.Common;
using EasyRent.Tests.Common.Data;
using EasyRent.Tests.Helpers;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace EasyRent.Tests.ServiceTests
{
    public class AdServiceTests
    {
        private readonly AdService adService;
        private readonly IUnitOfWork mockedUnitOfWork;

        public static IEnumerable<object[]> TestRequest { get; } = new List<object[]>
        {
            new object[] { new AdRequest() { Page = 0, PageSize = 5 } }
        };

        public AdServiceTests()
        {
            mockedUnitOfWork = new UnitOfWork(new TestApplicationDbContext(new DbContextOptions<ApplicationDbContext>()));

            adService = new AdService(mockedUnitOfWork, TestMapper.Instance);
        }

        [Theory]
        [MemberData(nameof(TestRequest))]
        public async Task Search(AdRequest request)
        {
            var searchResult = await adService.Search(request);

            Assert.True(searchResult.Count <= request.PageSize);
        }
    }
}