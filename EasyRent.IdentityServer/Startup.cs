using EasyRent.Common.Extentions;
using EasyRent.Data.Entities;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EasyRent.IdentityServer
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        private string MainDatabaseConnectionString
        {
            get
            {
                return Configuration.GetConnectionString("MainDatabase");
            }
        }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Environment = environment;
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseConfigs(MainDatabaseConnectionString)
                .AddDatabaseDependencies()
                .AddDataServiceDependencies()
                .AddAutoMapperConfigs<Startup>();

            services.AddMvc()
                .AddFluentValidation(config =>
                {
                    config.RunDefaultMvcValidationAfterFluentValidationExecutes = true;
                });

            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation(); // give oppotunity to change view in runtime.

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

            services.AddAuthenticationCore();

            services.AddCors(options =>
            {
                options.AddPolicy("default", policy =>
                {
                    policy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            services.AddAutoMapperConfigs<Startup>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseIdentityServer();
            app.UseRouting();
            app.UseEndpoints(configs =>
            {
                configs.MapDefaultControllerRoute(); //standart routing.
            });
        }
    }
}