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

namespace EasyRent.IdentityServer
{

    public class Startup
    {
        public IHostingEnvironment Environment { get; }
        
        public Startup(IHostingEnvironment environment)
        {
            Environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore();

            var builder = services.AddIdentityServer(options =>
                {
                    options.Events.RaiseErrorEvents = true;
                    options.Events.RaiseFailureEvents = true;
                    options.Events.RaiseInformationEvents = true;
                    options.Events.RaiseSuccessEvents = true;
                    options.Endpoints = new EndpointsOptions
                    {
                        EnableAuthorizeEndpoint = true,
                        EnableTokenEndpoint = false,
                        EnableCheckSessionEndpoint = true,
                        EnableEndSessionEndpoint = true,
                        EnableUserInfoEndpoint = true,
                        EnableDiscoveryEndpoint = true,
                        EnableIntrospectionEndpoint = false,
                        EnableTokenRevocationEndpoint = false,
                        EnableDeviceAuthorizationEndpoint = false,
                        EnableJwtRequestUri = true
                    };
                    options.Authentication = new AuthenticationOptions
                    {
                        CookieLifetime = TimeSpan.FromDays(1)
                    };
                })
                .AddInMemoryApiResources(Config.GetApiResources())
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryClients(Config.GetClients());
                // .AddAspNetIdentity<User>();

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

        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFileLogger();

            app.UseDeveloperExceptionPage();
            app.UseIdentityServer();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
