using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
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
                .AddStarWarsRepository()
                .AddPlanetsDbContext(config);

        private static IServiceCollection AddPlanetsDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(
                options =>
                {
                    options.UseSqlite(config.GetConnectionString("SQLite"));
                    options.EnableSensitiveDataLogging(false);
                });

            return services;
        }

        private static IServiceCollection AddStarWarsRepository(this IServiceCollection services)
        {
            services.AddTransient<IOrderOrquestrationRepository, OrderOrquestrationRepository>();
            return services;
        }
    }
}
