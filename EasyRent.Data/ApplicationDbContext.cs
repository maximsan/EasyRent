using EasyRent.Data.Entities;
using EasyRent.Data.Helpers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Address = EasyRent.Data.Entities.Address;

namespace EasyRent.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {
        #region DataSets

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<BookmarkAd> BookmarkAds { get; set; }
        public DbSet<BookmarkList> BookmarkLists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<AdComment> AdComments { get; set; }
        public DbSet<UserComment> UserComments { get; set; }

        #endregion DataSets

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

            builder.Entity<Contact>()
                   .HasOne(q => q.User)
                   .WithMany(q => q.Contacts)
                   .HasForeignKey(q => q.UserId);

            builder.Entity<Category>()
                   .HasMany(q => q.Subcategories)
                   .WithOne(q => q.Category)
                   .HasForeignKey(q => q.CategoryId);

            builder.Entity<Ad>()
                   .HasMany(q => q.Images)
                   .WithOne(q => q.Ad)
                   .HasForeignKey(q => q.AdId);

            builder.Entity<Ad>()
                .Property(q => q.Price)
                .HasColumnType("decimal(18,2)");

            builder.Entity<Ad>()
                .HasMany(q => q.AdComments)
                .WithOne(q => q.Ad)
                .HasForeignKey(q => q.AdId);

            builder.Entity<Ad>()
                .HasOne(q => q.Owner)
                .WithMany(q => q.Ads)
                .HasForeignKey(q => q.OwnerId);

            builder.Entity<UserComment>()
                .HasOne(q => q.Owner)
                .WithMany(q => q.OwnedComments)
                .HasForeignKey(q => q.OwnerId);

            builder.Entity<UserComment>()
                .HasOne(q => q.Publisher)
                .WithMany(q => q.PublishedComments)
                .HasForeignKey(q => q.PublisherId);

            SeedData(builder);

            base.OnModelCreating(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            #region Category and Subcategory seeding

            builder.Entity<Category>()
                .HasData(FakeData.GetCategories());

            builder.Entity<Subcategory>()
                .HasData(FakeData.GetSubcategories());

            #endregion Category and Subcategory seeding

            #region Users seeding

            builder.Entity<User>()
                .HasData(FakeData.GetFakeUsers());

            #endregion Users seeding

            #region Ads seeding

            builder.Entity<Ad>()
                .HasData(FakeData.GetFakeAds());

            #endregion Ads seeding
        }
    }
}