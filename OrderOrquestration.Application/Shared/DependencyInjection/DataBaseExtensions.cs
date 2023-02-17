using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrderOrquestration.Application.Shared.Context;
using OrderOrquestration.Application.Shared.Domain.Contracts;
using OrderOrquestration.Application.Shared.Repositories;

namespace OrderOrquestration.Application.Shared.DependencyInjection
{
    public static class DataBaseExtensions
    {
        public static IServiceCollection AddDataBaseExtensions(this IServiceCollection services, IConfiguration config) =>
            services
                .AddRepository()
                .AddAplicationDbContext(config);

        private static IServiceCollection AddAplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(
                options =>
                {
                    options.UseInMemoryDatabase("Db_Configurations");
                });

            return services;
        }

        private static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IOrderOrquestrationRepository, OrderOrquestrationRepository>();
            return services;
        }
    }
}
