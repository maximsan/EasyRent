using EasyRent.Common.Extensions;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EasyRent.Server
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public void Configure(IApplicationBuilder app)
        {
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
                app.UseHttpsRedirection();
            }

            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            
            app.UseRouting();

            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(configs =>
            {
                configs.MapControllers();
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

            services.AddDatabaseConfigs(Configuration.GetConnectionString("MainDatabase"))
                .AddDatabaseDependencies()
                .AddDataServiceDependencies()
                .AddValidationDependencies()
                .AddAutoMapperConfigs();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllers()
                .AddFluentValidation(config =>
                {
                    config.RunDefaultMvcValidationAfterFluentValidationExecutes = true;
                });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();
            services.AddAuthorization();

            services.AddSpaStaticFiles(config =>
            {
                config.RootPath = "wwwroot/build";
            });
        }
    }
}