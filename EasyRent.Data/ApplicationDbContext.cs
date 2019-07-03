using EasyRent.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyRent.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AdImage> AdImages { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<BookmarkAdBookmarkList> BookmarkAdBookmarkLists { get; set; }
        public DbSet<BookmarkAd> BookmarkAds { get; set; }
        public DbSet<BookmarkList> BookmarkLists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategorySubcategory> CategorySubcategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<UserAd> UserAds { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                   .HasOne(q => q.Address)
                   .WithOne(q => q.User)
                   .HasForeignKey<Address>(q => q.UserId);

            builder.Entity<UserContact>()
                   .HasOne(q => q.User)
                   .WithMany(q => q.UserContacts)
                   .HasForeignKey(q => q.UserId);

            builder.Entity<UserContact>()
                   .HasOne(q => q.Contact)
                   .WithMany(q => q.UserContacts)
                   .HasForeignKey(q => q.ContactId);

            builder.Entity<BookmarkAdBookmarkList>()
                   .HasOne(q => q.BookmarkList)
                   .WithMany(q => q.BookmarkAdBookmarkLists)
                   .HasForeignKey(q => q.BookmarkListId);

            builder.Entity<BookmarkAdBookmarkList>()
                   .HasOne(q => q.BookmarkAd)
                   .WithMany(q => q.BookmarkAdBookmarkLists)
                   .HasForeignKey(q => q.BookmarkAdId);

            builder.Entity<CategorySubcategory>()
                   .HasOne(q => q.Category)
                   .WithMany(q => q.CategorySubcategories)
                   .HasForeignKey(q => q.CategoryId);

            builder.Entity<CategorySubcategory>()
                   .HasOne(q => q.Subcategory)
                   .WithMany(q => q.CategorySubcategories)
                   .HasForeignKey(q => q.SubcategoryId);

            builder.Entity<AdImage>()
                   .HasOne(q => q.Ad)
                   .WithMany(q => q.AdImages)
                   .HasForeignKey(q => q.AdId);

            builder.Entity<AdImage>()
                   .HasOne(q => q.Image)
                   .WithMany(q => q.AdImages)
                   .HasForeignKey(q => q.ImageId);

            builder.Entity<UserAd>()
                   .HasOne(q => q.User)
                   .WithMany(q => q.UserAds)
                   .HasForeignKey(q => q.UserId);

            builder.Entity<UserAd>()
                   .HasOne(q => q.Ad)
                   .WithMany(q => q.UserAds)
                   .HasForeignKey(q => q.AdId);

            base.OnModelCreating(builder);
        }
    }
}