using AutoMapper;
using EasyRent.Data;
using EasyRent.Tests.Common.Startups;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace EasyRent.Tests.Common.Fixtures
{
    public class EasyRentServerFixture : WebApplicationFactory<EasyRentServerStartupTest>
    {
        public UnitOfWork UnitOfWork => GetService<UnitOfWork>();
        public IMapper Mapper => GetService<IMapper>();

        protected IServiceCollection serviceCollection;

        public T GetService<T>() where T : class
        {
            var descriptor = serviceCollection.FirstOrDefault(q => q.ServiceType == typeof(T));

            if (descriptor.ImplementationInstance != null)
            {
                return (T)descriptor.ImplementationInstance;
            }

            if (descriptor.ImplementationType != null)
            {
                return (T)ActivatorUtilities.CreateInstance(serviceCollection.BuildServiceProvider(), descriptor.ImplementationType);
            }

            if (descriptor.ImplementationFactory != null)
            {
                return (T)descriptor.ImplementationFactory(serviceCollection.BuildServiceProvider());
            }

            throw new InvalidOperationException($"Could not create instance for {descriptor.ServiceType}");
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            base.ConfigureWebHost(builder);

            builder.ConfigureTestServices(servicesConfiguration =>
            {
                serviceCollection = servicesConfiguration;
            });
        }

        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            return WebHost.CreateDefaultBuilder()
                .UseStartup<EasyRentServerStartupTest>();
        }
    }
}