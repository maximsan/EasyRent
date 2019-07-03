using System;
using EasyRent.Data.Repositories;

namespace EasyRent.Data
{
    public class UnitOfWork : IDisposable
    {
        private bool disposed;

        private readonly ApplicationDbContext dbContext;

        private AddressRepository addressRepository;
        private AdRepository adRepository;
        private CategoryRepository categoryRepository;
        private ContactRepository contactRepository;
        private ImageRepository imageRepository;
        private SubcategoryRepository subcategoryRepository;
        private UserContactRepository userContactRepository;

        public AddressRepository AddressRepository =>
            addressRepository ?? (addressRepository = new AddressRepository(dbContext));

        public AdRepository AdRepository => adRepository ?? (adRepository = new AdRepository(dbContext));

        public CategoryRepository CategoryRepository =>
            categoryRepository ?? (categoryRepository = new CategoryRepository(dbContext));

        public ContactRepository ContactRepository =>
            contactRepository ?? (contactRepository = new ContactRepository(dbContext));

        public ImageRepository ImageRepository => imageRepository ?? (imageRepository = new ImageRepository(dbContext));

        public SubcategoryRepository SubcategoryRepository =>
            subcategoryRepository ?? (subcategoryRepository = new SubcategoryRepository(dbContext));

        public UserContactRepository UserContactRepository =>
            userContactRepository ?? (userContactRepository = new UserContactRepository(dbContext));

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (disposed)
                {
                    // UserManager.Dispose();
                    AddressRepository.Dispose();
                }

                disposed = true;
            }
        }
    }
}