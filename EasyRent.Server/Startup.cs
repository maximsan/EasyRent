using EasyRent.Common.Extentions;
using EasyRent.Server.Common.Constants;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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

            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapSpaFallbackRoute("spa-fallback", new
                {
                    controller = "Home",
                    action = "Index"
                });
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
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

            services.AddDatabaseConfigs(Configuration.GetConnectionString("MainDatabase"));

            services.AddMvc()
                .AddFluentValidation(config =>
                {
                    config.RunDefaultMvcValidationAfterFluentValidationExecutes = true;
                });

            services.AddAuthentication("Bearer")
                .AddIdentityServerAuthentication(configs =>
                {
                    configs.ApiName = CommonConstants.ApiName;
                    configs.Authority = "http://localhost:5002";
                    configs.RequireHttpsMetadata = false;
                    configs.SaveToken = true;
                });

            services.AddSpaStaticFiles(config =>
            {
                config.RootPath = "wwwroot/build";
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDatabaseDependencies();
            services.AddDataServiceDependencies();
            services.AddValidationDependencies();
            services.AddAutoMapperConfigs<Startup>();
        }
    }
}