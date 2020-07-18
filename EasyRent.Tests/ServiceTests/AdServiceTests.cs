using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.BusinessLayer.Services;
using EasyRent.Data.Interfaces;
using EasyRent.Tests.Common;
using EasyRent.Tests.Common.Fixtures;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace EasyRent.Tests.ServiceTests
{
    public class AdServiceTests : IClassFixture<DatabaseFixture>
    {
        private readonly AdService adService;
        private readonly IUnitOfWork unitOfWork;

        public static IEnumerable<object[]> TestRequest { get; } = new List<object[]>
        {
            new object[] { new AdRequest() { Page = 0, PageSize = 5 } }
        };

        public AdServiceTests(DatabaseFixture databaseFixture)
        {
            unitOfWork = databaseFixture.UnitOfWork;

            adService = new AdService(unitOfWork, TestMapper.Instance);
        }

        [Theory]
        [MemberData(nameof(TestRequest))]
        public async Task Search(AdRequest request)
        {
            var searchResult = await adService.SearchAsync(request);

            Assert.True(searchResult.Count == request.PageSize);
        }
    }
}