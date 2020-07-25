using EasyRent.Data.Entities;

namespace EasyRent.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Address> AddressRepository { get; }
        IAdRepository AdRepository { get; }
        IRepository<Category> CategoryRepository { get; }
        IRepository<Contact> ContactRepository { get; }
        IRepository<Image> ImageRepository { get; }
        IRepository<Subcategory> SubcategoryRepository { get; }

        void Dispose();
    }
}