using EasyRent.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EasyRent.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {
        private static readonly Category[] SeedDataCategories = new Category[]
        {
            new Category { Name = "Одежда и аксессуары" },
            new Category { Name = "Детские товары" },
            new Category { Name = "Техника и электроника" },
            new Category { Name = "Хобби и отдых" },
            new Category { Name = "Свадьба и праздники" },
            new Category { Name = "Автотовары" },
            new Category { Name = "Сад и огород" },
            new Category { Name = "Здоровье" },
            new Category { Name = "Спорт, туризм и активный отдых" },
            new Category { Name = "Ремонт и стройка" },
            new Category { Name = "Другое" }
        };

        private static readonly Subcategory[] SeedDataSubcategories = new Subcategory[]
        {
            new Subcategory { Name = "Мужская одежда", CategoryId = 1 },
            new Subcategory { Name = "Женская одежда", CategoryId = 1 },
            new Subcategory { Name = "Обувь", CategoryId = 1 },
            new Subcategory { Name = "Для мероприятий", CategoryId = 1 }, //??
            new Subcategory { Name = "Аксессуары", CategoryId = 1 },
            new Subcategory { Name = "Другое", CategoryId = 1 },

            new Subcategory { Name = "Одежда", CategoryId = 2 },
            new Subcategory { Name = "Игрушки", CategoryId = 2 },
            new Subcategory { Name = "Транспорт и коляски", CategoryId = 2 },
            new Subcategory { Name = "Другое", CategoryId = 2 },

            new Subcategory { Name = "Бытовая техника", CategoryId = 3 },
            new Subcategory { Name = "Телефоны, планшеты, гаджеты", CategoryId = 3 },
            new Subcategory { Name = "Компьютерная техника", CategoryId = 3 },
            new Subcategory { Name = "Консоли", CategoryId = 3 },
            new Subcategory { Name = "Другое", CategoryId = 3 },

            new Subcategory { Name = "Компьютерные игры", CategoryId = 3 },
            new Subcategory { Name = "Настольные игры", CategoryId = 3 },
            new Subcategory { Name = "Музыкальные инструменты", CategoryId = 3 },
            new Subcategory { Name = "Книги и журналы", CategoryId = 3 },
            new Subcategory { Name = "Охота и рыбалка", CategoryId = 3 },
            new Subcategory { Name = "Другое", CategoryId = 3 },

            new Subcategory { Name = "Мебель", CategoryId = 4 },
            new Subcategory { Name = "Автомобили", CategoryId = 4 },
            new Subcategory { Name = "Мотоциклы, квадроциклы", CategoryId = 4 },
            new Subcategory { Name = "Инструмент", CategoryId = 4 },
            new Subcategory { Name = "Другое", CategoryId = 4 },

            new Subcategory { Name = "Тренажеры", CategoryId = 5 },
            new Subcategory { Name = "Другое", CategoryId = 5 },

            new Subcategory { Name = "Зимние спорттовары", CategoryId = 6 },
            new Subcategory { Name = "Летние спорттовары", CategoryId = 6 },
            new Subcategory { Name = "Всесезонные спорттовары", CategoryId = 6 },
            new Subcategory { Name = "Туристические товары", CategoryId = 6 },
            new Subcategory { Name = "Велотовары", CategoryId = 6 },
            new Subcategory { Name = "Туристические услуги", CategoryId = 6 },
            new Subcategory { Name = "Другое", CategoryId = 6 }
        };

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<BookmarkAd> BookmarkAds { get; set; }
        public DbSet<BookmarkList> BookmarkLists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<UserAd> UserAds { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                   .HasOne(q => q.Address)
                   .WithOne(q => q.User)
                   .HasForeignKey<Address>(q => q.UserId);

            builder.Entity<User>()
                .HasOne(q => q.BookmarkList)
                .WithOne(q => q.User)
                .HasForeignKey<BookmarkList>(q => q.UserId);

            builder.Entity<BookmarkList>()
                .HasMany(q => q.BookmarkAds)
                .WithOne(q => q.BookmarkList)
                .HasForeignKey(q => q.BookmarkListId);

            builder.Entity<UserContact>()
                   .HasOne(q => q.User)
                   .WithMany(q => q.UserContacts)
                   .HasForeignKey(q => q.UserId);

            builder.Entity<UserContact>()
                   .HasOne(q => q.Contact)
                   .WithMany(q => q.UserContacts)
                   .HasForeignKey(q => q.ContactId);

            builder.Entity<Category>()
                .HasMany(q => q.Subcategories)
                .WithOne(q => q.Category)
                .HasForeignKey(q => q.CategoryId);

            builder.Entity<Ad>()
                .HasMany(q => q.Images)
                .WithOne(q => q.Ad)
                .HasForeignKey(q => q.AdId);

            builder.Entity<UserAd>()
                   .HasOne(q => q.User)
                   .WithMany(q => q.UserAds)
                   .HasForeignKey(q => q.UserId);

            builder.Entity<UserAd>()
                   .HasOne(q => q.Ad)
                   .WithMany(q => q.UserAds)
                   .HasForeignKey(q => q.AdId);

            SeedData(builder);

            base.OnModelCreating(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            #region Category and Subcategory seeding

            int subcategoryId = 0;
            for (int categoryId = 1; categoryId < SeedDataCategories.Length; categoryId++)
            {
                var category = SeedDataCategories[categoryId];
                category.CategoryId = categoryId;
                var subcategories = SeedDataSubcategories.Where(q => q.CategoryId == category.CategoryId).ToArray();

                builder.Entity<Category>()
                    .HasData(category);

                foreach (var subcategory in subcategories)
                {
                    subcategoryId++;

                    subcategory.SubcategoryId = subcategoryId;

                    builder.Entity<Subcategory>()
                        .HasData(subcategory);
                }
            }

            #endregion Category and Subcategory seeding
        }
    }
}