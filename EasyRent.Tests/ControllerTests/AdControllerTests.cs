using EasyRent.BusinessLayer.Interfaces;
using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.BusinessLayer.Services;
using EasyRent.Server.Controllers;
using EasyRent.Tests.Common;
using EasyRent.Tests.Common.Fixtures;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace EasyRent.Tests.ControllerTests
{
    public class AdControllerTests : IClassFixture<UnitOfWorkFixture>
    {
        private readonly AdController _controller;
        private readonly IAdService _adService;
        private readonly UnitOfWorkFixture _fixture;

        public static IEnumerable<object[]> TestRequest { get; } = new List<object[]>
        {
            new object[] { new AdRequest() { Page = 0, PageSize = 5 } }
        };

        public AdControllerTests(UnitOfWorkFixture fixture)
        {
            _fixture = fixture;
            _adService = new AdService(_fixture.UnitOfWork, TestMapper.Instance);
            _controller = new AdController(_adService);
        }

        [Theory]
        [MemberData(nameof(TestRequest))]
        public async Task GetAds(AdRequest request)
        {
            var actionResult = await _controller.SearchAsync(request);

            var convertedActionResult = Assert.IsType<OkObjectResult>(actionResult);
            var model = Assert.IsAssignableFrom<IEnumerable<AdModel>>(convertedActionResult.Value);

            Assert.True(model.Count() <= request.PageSize);
        }
    }
}