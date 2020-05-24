using EasyRent.Data.Entities;
using EasyRent.Data.Repositories;
using System;

namespace EasyRent.Data
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly ApplicationDbContext dbContext;

        private IRepository<Address> addressRepository;
        private IAdRepository adRepository;
        private IRepository<Category> categoryRepository;
        private IRepository<Contact> contactRepository;
        private IRepository<Image> imageRepository;
        private IRepository<Subcategory> subcategoryRepository;
        private IRepository<UserContact> userContactRepository;

        public IRepository<Address> AddressRepository =>
            addressRepository ?? (addressRepository = new AddressRepository(dbContext));

        public IAdRepository AdRepository => adRepository ?? (adRepository = new AdRepository(dbContext));

        public IRepository<Category> CategoryRepository =>
            categoryRepository ?? (categoryRepository = new CategoryRepository(dbContext));

        public IRepository<Contact> ContactRepository =>
            contactRepository ?? (contactRepository = new ContactRepository(dbContext));

        public IRepository<Image> ImageRepository => imageRepository ?? (imageRepository = new ImageRepository(dbContext));

        public IRepository<Subcategory> SubcategoryRepository =>
            subcategoryRepository ?? (subcategoryRepository = new SubcategoryRepository(dbContext));

        public IRepository<UserContact> UserContactRepository =>
            userContactRepository ?? (userContactRepository = new UserContactRepository(dbContext));

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #region Disposable

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!disposed)
                {
                    dbContext.Dispose();
                }

                disposed = true;
            }
        }

        #endregion Disposable
    }
}