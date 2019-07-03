using EasyRent.Data.Entities;

namespace EasyRent.Data.Repositories
{
    public class ContactRepository : BaseRepository<Contact>
    {
        public ContactRepository(ApplicationDbContext context) : base(context) { }
    }
}