using AutoMapper;
using EasyRent.Common.Models;
using EasyRent.Common.Models.AdModels;
using EasyRent.Common.Models.UserModels;
using EasyRent.Common.Services;
using EasyRent.Common.Validators;
using EasyRent.Data;
using EasyRent.Data.Entities;
using EasyRent.Data.Repositories;
using EasyRent.Data.Repositories.Filters;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRent.Common.Extentions
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

        public static IServiceCollection AddAutoMapperConfigs<TStartup>(this IServiceCollection services) where TStartup : class
        {
            services.AddAutoMapper(config =>
            {
                config.CreateMap<SignInModel, User>();
                config.CreateMap<SignUpModel, User>();
                config.CreateMap<Ad, AdViewModel>();
                config.CreateMap<AdRequest, AdFilter>();
                config.CreateMap<AdModel, Ad>();
                config.CreateMap<Address, AddressModel>();
            }, typeof(TStartup));

            return services;
        }

        public static IServiceCollection AddDatabaseDependencies(this IServiceCollection services)
        {
            services.AddTransient<AddressRepository>();
            services.AddTransient<AdRepository>();
            services.AddTransient<CategoryRepository>();
            services.AddTransient<ContactRepository>();
            services.AddTransient<ImageRepository>();
            services.AddTransient<SubcategoryRepository>();
            services.AddTransient<UserContactRepository>();
            services.AddTransient<UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddDatabaseConfigs(this IServiceCollection services, string connString)
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