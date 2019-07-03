using EasyRent.Data.Entities;

namespace EasyRent.Data.Repositories
{
    public class AdRepository : BaseRepository<Ad>
    {
        public AdRepository(ApplicationDbContext context) : base(context) { }
    }
}