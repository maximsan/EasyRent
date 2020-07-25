using AutoMapper;
using EasyRent.BusinessLayer.Interfaces;
using EasyRent.BusinessLayer.Models;
using EasyRent.BusinessLayer.Services;
using EasyRent.BusinessLayer.Validators;
using EasyRent.Data;
using EasyRent.Data.Entities;
using EasyRent.Data.Interfaces;
using EasyRent.Data.Repositories;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace EasyRent.BusinessLayer.Extensions
{
    public static class ServiceCollectionServiceExtensions
    {
        public static IServiceCollection AddValidationDependencies(this IServiceCollection services)
        {
            services.AddTransient<IValidator<SignInModel>, SignInValidator>();
            services.AddTransient<IValidator<SignUpModel>, SignUpValidator>();
            services.AddTransient<IValidator<ResetPasswordModel>, ResetPasswordValidator>();

            return services;
        }

        public static IServiceCollection AddAutoMapperConfigs(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }

        public static IServiceCollection AddDatabaseDependencies(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Address>, AddressRepository>();
            services.AddTransient<IAdRepository, AdRepository>();
            services.AddTransient<IRepository<Category>, CategoryRepository>();
            services.AddTransient<IRepository<Contact>, ContactRepository>();
            services.AddTransient<IRepository<Image>, ImageRepository>();
            services.AddTransient<IRepository<Subcategory>, SubcategoryRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddDatabaseConfigs(this IServiceCollection services, string connString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connString);
            });

            services.AddIdentity<User, Role>(config =>
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

            return services;
        }

        public static IServiceCollection AddDataServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IAdService, AdService>();
            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}