using EasyRent.Data.Entities;

namespace EasyRent.Data.Repositories
{
    public class AddressRepository : BaseRepository<Address>
    {
        public AddressRepository(ApplicationDbContext context) : base(context) { }
    }
}