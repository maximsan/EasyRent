using EasyRent.Data.Entities;

namespace EasyRent.Data.Repositories
{
    public class ImageRepository : BaseRepository<Image>
    {
        public ImageRepository(ApplicationDbContext context) : base(context) { }
    }
}
