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
    public class AdServiceTest : IClassFixture<UnitOfWorkFixture>
    {
        private readonly AdService _adService;
        private readonly IUnitOfWork _unitOfWork;

        public static IEnumerable<object[]> TestRequest { get; } = new List<object[]>
        {
            new object[] { new AdRequest() { Page = 0, PageSize = 5 } }
        };

        public AdServiceTest(UnitOfWorkFixture databaseFixture)
        {
            _unitOfWork = databaseFixture.UnitOfWork;
            _adService = new AdService(_unitOfWork, TestMapper.Instance);
        }

        [Theory]
        [MemberData(nameof(TestRequest))]
        public async Task Search(AdRequest request)
        {
            var searchResult = await _adService.SearchAsync(request);

            Assert.True(searchResult.Count == request.PageSize);
        }
    }
}