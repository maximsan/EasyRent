using AutoMapper;
using EasyRent.Common.Extentions;
using EasyRent.Common.Models;
using EasyRent.Data;
using EasyRent.Data.Entities;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EasyRent.IdentityServer
{

    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }
        private string MainDatabaseConnectionString
        {
            get
            {
                return Configuration.GetConnectionString("MainDatabase");
            }
        }

        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Environment = environment;
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(MainDatabaseConnectionString);
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

            services.AddMvcCore()
                .AddJsonFormatters()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(config =>
                {
                    config.RunDefaultMvcValidationAfterFluentValidationExecutes = true;
                });

            var builder = services.AddIdentityServer(options =>
                {
                    options.Events.RaiseErrorEvents = true;
                    options.Events.RaiseFailureEvents = true;
                    options.Events.RaiseInformationEvents = true;
                    options.Events.RaiseSuccessEvents = true;
                    options.UserInteraction.LoginUrl = "http://localhost:5002/account/SignIn";
                    options.UserInteraction.LogoutUrl = "http://localhost:5002/account/sign-out";
                    options.IssuerUri = "http://localhost:5002";
                })
                .AddInMemoryApiResources(Config.GetApiResources())
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryClients(Config.GetClients())
                .AddAspNetIdentity<User>();

            if (Environment.IsDevelopment())
            {
                builder.AddDeveloperSigningCredential();
            }
            else
            {
                //TODO: Need configure key material.
            }

            services.AddAuthentication();

            services.AddCors(options =>
            {
                options.AddPolicy("default", policy =>
                {
                    policy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            services.AddAutoMapper(config =>
            {
                config.CreateMap<SignInModel, User>();
                config.CreateMap<SignUpModel, User>();
            }, typeof(Startup));
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFileLogger();

            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseIdentityServer();
            app.UseMvcWithDefaultRoute();
        }
    }
}
