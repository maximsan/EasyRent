using EasyRent.Common.Extentions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EasyRent.Tests.Common.Startups
{
    public class EasyRentServerStartupTest
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        public string MainDatabaseConnectionString => "Server=localhost;Database=EasyRent;User Id=EasyRent;Password=12345;";

        public EasyRentServerStartupTest(IConfiguration configuration, IWebHostEnvironment environment)
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

            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseCookiePolicy();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDatabaseConfigs(MainDatabaseConnectionString);

            services.AddMvc();

            services.AddAuthentication();

            services.AddSpaStaticFiles(config =>
            {
                config.RootPath = "wwwroot/build";
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDatabaseDependencies();
            services.AddDataServiceDependencies();
            services.AddAutoMapperConfigs();
        }
    }
}