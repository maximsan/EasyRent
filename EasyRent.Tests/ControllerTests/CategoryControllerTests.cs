using EasyRent.BusinessLayer.Models.CategoryModels;
using EasyRent.Server.Controllers;
using EasyRent.Tests.Common;
using EasyRent.Tests.Common.Fixtures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Xunit;

namespace EasyRent.Tests.ControllerTests
{
    public class CategoryControllerTests : IClassFixture<UnitOfWorkFixture>
    {
        private readonly CategoryController _controller;
        private readonly UnitOfWorkFixture _fixture;

        public CategoryControllerTests(UnitOfWorkFixture fixture)
        {
            _fixture = fixture;
            _controller = new CategoryController(_fixture.UnitOfWork.CategoryRepository, TestMapper.Instance);
        }

        [Fact]
        public async Task GetCategoriesAsync()
        {
            var result = await _controller.GetCategoriesAsync();

            var convertedResult = Assert.IsType<OkObjectResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<CategoryModel>>(convertedResult.Value);

            Assert.Equal(await _fixture.DbContext.Categories.CountAsync(), model.Count());
        }
    }
}