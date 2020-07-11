﻿using EasyRent.BusinessLayer.Interfaces;
using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.Server.Controllers;
using EasyRent.Tests.Helpers.DataHelpers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace EasyRent.Tests.ControllerTests
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
        public async Task GetAds(AdRequest request)
        {
            mockedAdService.Setup(q => q.SearchAsync(request)).Returns(AdHelper.Search(request));

            var actionResult = await controller.Search(request);

            var convertedActionResult = Assert.IsType<OkObjectResult>(actionResult);
            var model = Assert.IsAssignableFrom<IEnumerable<AdModel>>(convertedActionResult.Value);

            Assert.True(model.Count() <= request.PageSize);
        }
    }
}