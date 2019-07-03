using EasyRent.Data.Entities;

namespace EasyRent.Data.Repositories
{
    public class UserContactRepository : BaseRepository<UserContact>

    {
        public UserContactRepository(ApplicationDbContext context) : base(context) { }
    }
}
