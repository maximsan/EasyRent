using EasyRent.Common.Models.AdModels;
using EasyRent.Common.Services;
using EasyRent.Server.Controllers;
using EasyRent.Tests.Common.Fixtures;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace EasyRent.Tests.Controllers.Server
{
    public class AdControllerTests : IClassFixture<EasyRentServerFixture>
    {
        private readonly AdController controller;
        private readonly EasyRentServerFixture fixture;
        private readonly HttpClient httpClient;

        public AdControllerTests(EasyRentServerFixture fixture)
        {
            this.fixture = fixture;
            httpClient = this.fixture.CreateClient();
            controller = new AdController(fixture.UnitOfWork, fixture.Mapper, fixture.GetService<AdService>());
        }

        [Theory]
        [InlineData(null)]
        public async Task GetTest(int? adId)
        {
            var request = new AdRequest
            {
                AdId = adId
            };

            var result = await controller.Get(request);

            Assert.NotNull(result);
        }
    }
}