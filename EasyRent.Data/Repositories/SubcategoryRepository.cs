using EasyRent.Data.Entities;

namespace EasyRent.Data.Repositories
{
    public class SubcategoryRepository : BaseRepository<Subcategory>
    {
        public SubcategoryRepository(ApplicationDbContext context) : base(context) { }
    }
}
