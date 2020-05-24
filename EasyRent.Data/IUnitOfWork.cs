using EasyRent.Data.Entities;
using EasyRent.Data.Repositories;

namespace EasyRent.Data
{
    public interface IUnitOfWork
    {
        IRepository<Address> AddressRepository { get; }
        IAdRepository AdRepository { get; }
        IRepository<Category> CategoryRepository { get; }
        IRepository<Contact> ContactRepository { get; }
        IRepository<Image> ImageRepository { get; }
        IRepository<Subcategory> SubcategoryRepository { get; }
        IRepository<UserContact> UserContactRepository { get; }

        void Dispose();
    }
}