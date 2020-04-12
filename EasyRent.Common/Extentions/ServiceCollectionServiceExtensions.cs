using AutoMapper;
using EasyRent.Common.Models;
using EasyRent.Common.Models.AdModels;
using EasyRent.Common.Validators;
using EasyRent.Data.Entities;
using EasyRent.Data.Repositories.Filters;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRent.Common.Extentions
{
    public static class ServiceCollectionServiceExtensions
    {
        public static void AddValidationDependencies(this IServiceCollection services)
        {
            services.AddTransient<IValidator<SignInModel>, SignInValidator>();
            services.AddTransient<IValidator<SignUpModel>, SignUpValidator>();
            services.AddTransient<IValidator<ResetPasswordModel>, ResetPasswordValidator>();
        }

        public static void AddAutoMapperConfigs<TStartup>(this IServiceCollection services) where TStartup : class
        {
            services.AddAutoMapper(config =>
            {
                config.CreateMap<SignInModel, User>();
                config.CreateMap<SignUpModel, User>();
                config.CreateMap<Ad, AdViewModel>();
                config.CreateMap<AdRequest, AdFilter>();
                config.CreateMap<AdModel, Ad>();
            }, typeof(TStartup));
        }
    }
}