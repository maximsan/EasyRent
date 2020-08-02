using EasyRent.Data.Entities;
using EasyRent.Data.Repositories;
using EasyRent.Tests.Common.Fixtures;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace EasyRent.Tests.Repositories
{
    public class AdRepositoryTest : IClassFixture<ApplicationDbContextFixture>
    {
        private readonly ApplicationDbContextFixture _dbFixture;
        private readonly AdRepository _adRepo;

        public AdRepositoryTest(ApplicationDbContextFixture dbFixture)
        {
            _dbFixture = dbFixture;
            _adRepo = new AdRepository(_dbFixture.DbContext);
        }

        [Fact]
        public async Task GetAllAsync()
        {
            var query = _adRepo.GetAll();
            var expected = await query.ToListAsync();
            var actual = await _dbFixture.DbContext.Ads.ToListAsync();

            Assert.True(expected.Count == actual.Count);
        }

        [Fact]
        public async Task AddAsync()
        {
            var entity = new Ad
            {
                AdId = 101,
                Title = "Test"
            };

            await _adRepo.CreateAsync(entity);

            Assert.Null(_adRepo.GetAll().FirstOrDefault(q => q.AdId == entity.AdId));

            await _adRepo.SaveAsync();

            Assert.NotNull(_adRepo.GetAll().FirstOrDefault(q => q.AdId == entity.AdId));
        }

        [Theory]
        [InlineData(50, "Test")]
        public async Task UpdateAsync(int id, string title)
        {
            var entity = await _adRepo.GetByIdAsync(id);
            entity.Title = title;

            _adRepo.Update(entity);
            await _adRepo.SaveAsync();

            Assert.Equal((await _adRepo.GetByIdAsync(id))?.Title, title);
        }

        [Theory]
        [InlineData(80)]
        public async Task DeleteAsync(int id)
        {
            var entity = await _adRepo.GetByIdAsync(id);

            _adRepo.Delete(entity);
            await _adRepo.SaveAsync();

            Assert.Null(await _adRepo.GetByIdAsync(id));
        }
    }
}