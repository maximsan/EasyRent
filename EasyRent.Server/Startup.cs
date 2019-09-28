using AutoMapper;
using EasyRent.Common.Extentions;
using EasyRent.Common.Models;
using EasyRent.Common.Validators;
using EasyRent.Data;
using EasyRent.Data.Entities;
using EasyRent.Data.Repositories;
using EasyRent.Server.Common.Constants;
using EasyRent.Server.Models;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using EasyRent.Common.Filters;

namespace EasyRent.Server
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFileLogger();

            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
                app.UseHttpsRedirection();
            }

            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseCors("default"); //TODO: Web API still gets any requests. We have to change it in the future.

            app.UseMvc(routes =>
            {
                routes.MapSpaFallbackRoute("spa-fallback", new
                {
                    controller = "Home",
                        action = "Index"
                });
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "wwwroot";

                if (Environment.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer("start");
                }
            });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            InitDatabaseConfigurations(services);

            services.AddMvcCore()
                .AddMvcOptions(options =>
                {
                    options.Filters.Add(typeof(GlobalExceptionFilter));
                })
                .AddJsonFormatters()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(config =>
                {
                    config.RunDefaultMvcValidationAfterFluentValidationExecutes = true;
                })
                .AddAuthorization(options =>
                {
                    options.AddPolicy("AdminsOnly", policy =>
                    {
                        policy.RequireClaim("role", "admin");
                    });
                });

            services.AddAuthentication()
                .AddIdentityServerAuthentication(configs =>
                {
                    configs.ApiName = CommonConstants.ApiName;
                    configs.Authority = "http://localhost:5002";
                    configs.RequireHttpsMetadata = false;
                    configs.SaveToken = true;
                    configs.RoleClaimType = "role";
                    configs.NameClaimType = "username";
                });

            services.AddCors(options =>
            {
                options.AddPolicy("default", policy =>
                {
                    policy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            services.AddSpaStaticFiles(config =>
            {
                config.RootPath = "wwwroot/build";
            });

            InitDependencies(services);
        }

        private void InitDatabaseConfigurations(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("MainDatabase"));
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
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }

        private void InitDependencies(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddTransient<AddressRepository>();
            services.AddTransient<AdRepository>();
            services.AddTransient<CategoryRepository>();
            services.AddTransient<ContactRepository>();
            services.AddTransient<ImageRepository>();
            services.AddTransient<SubcategoryRepository>();
            services.AddTransient<UserContactRepository>();
            services.AddScoped<UnitOfWork>();

            services.AddTransient<IValidator<SignInModel>, SignInValidator>();
            services.AddTransient<IValidator<SignUpModel>, SignUpValidator>();
            services.AddTransient<IValidator<ResetPasswordModel>, ResetPasswordValidator>();

            services.AddAutoMapper(config =>
            {
                config.CreateMap<SignInModel, User>();
                config.CreateMap<SignUpModel, User>();
                config.CreateMap<ProductModel, Ad>();
            }, typeof(Startup));
        }
    }
}
