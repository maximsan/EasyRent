using EasyRent.Data.Entities;

namespace EasyRent.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(ApplicationDbContext context) : base(context) { }
    }
}
