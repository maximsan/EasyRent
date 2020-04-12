using EasyRent.Data.Entities;
using EasyRent.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRent.Data.Extentions
{
    public static class ServiceCollectionServiceExtensions
    {
        public static void AddDatabaseDependencies(this IServiceCollection services)
        {
            services.AddTransient<AddressRepository>();
            services.AddTransient<AdRepository>();
            services.AddTransient<CategoryRepository>();
            services.AddTransient<ContactRepository>();
            services.AddTransient<ImageRepository>();
            services.AddTransient<SubcategoryRepository>();
            services.AddTransient<UserContactRepository>();
            services.AddScoped<UnitOfWork>();
        }

        public static void AddDatabaseConfigs(this IServiceCollection services, string connString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connString);
            });

            services.AddDefaultIdentity<User>(config =>
            {
                config.User.RequireUniqueEmail = true;
                config.Password = new PasswordOptions
                {
                    RequireDigit = false,
                    RequireLowercase = false,
                    RequireNonAlphanumeric = false,
                    RequireUppercase = false,
                    RequiredLength = 5
                };
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();
        }
    }
}