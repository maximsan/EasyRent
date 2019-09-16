using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRent.Data.Entities;
using IdentityServer4;
using IdentityServer4.Configuration;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using EasyRent.Common.Extentions;
using Microsoft.AspNetCore.Identity;
using EasyRent.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using EasyRent.Common.Models;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.AspNetCore;

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
                    options.UserInteraction.LoginUrl = "http://localhost:5001/signin";
                    // options.Endpoints = new EndpointsOptions
                    // {
                    //     EnableAuthorizeEndpoint = true,
                    //     EnableTokenEndpoint = false,
                    //     EnableCheckSessionEndpoint = true,
                    //     EnableEndSessionEndpoint = true,
                    //     EnableUserInfoEndpoint = true,
                    //     EnableDiscoveryEndpoint = true,
                    //     EnableIntrospectionEndpoint = false,
                    //     EnableTokenRevocationEndpoint = false,
                    //     EnableDeviceAuthorizationEndpoint = false,
                    //     EnableJwtRequestUri = true
                    // };
                    // options.Authentication = new AuthenticationOptions
                    // {
                    //     CookieLifetime = TimeSpan.FromDays(1)
                    // };
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

            services.AddAuthentication("Cookie")
            .AddCookie("Cookie", options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
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
