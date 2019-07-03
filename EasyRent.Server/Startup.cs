using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EasyRent.Server.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;

namespace EasyRent.Server
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            InitDatabaseConfigurations(services);

            services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSpaStaticFiles(config =>
            {
                config.RootPath = "wwwroot/build";
            });

            InitDependencies(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddFileLogger();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                app.UseHttpsRedirection();
            }

            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute("spa-fallback", new { controller = "Home", action = "Index" });
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "wwwroot";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer("start");
                }
            });
        }

        private void InitDatabaseConfigurations(IServiceCollection services)
        {
            //services.AddDbContext<ApplicationDbContext>(
            //    options => options.UseNpgsql(Configuration.GetConnectionString("MainDatabase")));

            //services.AddDefaultIdentity<User>()
            //        .AddDefaultUI(UIFramework.Bootstrap4)
            //        .AddEntityFrameworkStores<ApplicationDbContext>();
        }

        private void InitDependencies(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //services.AddTransient<AddressRepository>();
            //services.AddTransient<AdRepository>();
            //services.AddTransient<CategoryRepository>();
            //services.AddTransient<ContactRepository>();
            //services.AddTransient<ImageRepository>();
            //services.AddTransient<SubcategoryRepository>();
            //services.AddTransient<UserContactRepository>();
            //services.AddScoped<UnitOfWork>();
        }
    }
}
