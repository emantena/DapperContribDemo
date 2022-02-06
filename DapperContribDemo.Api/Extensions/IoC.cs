using DapperContribDemo.Api.Mapper;
using DapperPoc.Domain;
using DapperPoc.Domain.Interfaces.Repositories;
using DapperPoc.Domain.Interfaces.Services;
using DapperPoc.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DapperContribDemo.Api.Extensions
{
    public static class IoC
    {
        public static void IoCSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddSingleton(configuration);

            AddRepository(services);
            AddServices(services);
            AddAutoMapper(services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
        }

        private static void AddRepository(IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }

        private static void AddAutoMapper(IServiceCollection services)
        {
            var config = AutoMapperConfig.RegisterMappings().CreateMapper();

            services.AddSingleton(config);
        }
    }
}
