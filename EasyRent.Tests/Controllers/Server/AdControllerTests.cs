using EasyRent.BusinessLayer.Interfaces;
using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.Server.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace EasyRent.Tests.Controllers.Server
{
    public class AdControllerTests
    {
        private readonly AdController controller;
        private readonly Mock<IAdService> mockedAdService;

        public static IEnumerable<object[]> TestRequest { get; } = new List<object[]>
        {
            new object[] { new AdRequest() { Page = 0, PageSize = 5 } }
        };

        public AdControllerTests()
        {
            mockedAdService = new Mock<IAdService>();

            controller = new AdController(mockedAdService.Object);
        }

        [Theory]
        [MemberData(nameof(TestRequest))]
        public async Task GetTest(AdRequest request)
        {
            var actionResult = await controller.Search(request);

            var convertedActionResult = Assert.IsType<OkObjectResult>(actionResult);
            var model = Assert.IsAssignableFrom<IEnumerable<AdViewModel>>(convertedActionResult);
            Assert.True(model.Count() <= request.PageSize);
        }
    }
}