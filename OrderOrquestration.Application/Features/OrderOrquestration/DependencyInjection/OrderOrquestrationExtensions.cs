using OrderOrquestration.Application.Features.OrderOrquestration.UseCase;
using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace OrderOrquestration.Application.Features.OrderOrquestration.DependencyInjection
{
    public static class OrderOrquestrationExtensions
    {
        public static IServiceCollection AddOrderOrquestrationExtensions(this IServiceCollection services) =>
            services
                .AddMediatRExtensions();

        private static IServiceCollection AddMediatRExtensions(this IServiceCollection services)
        {
            services.AddMediatR(typeof(OrderOrquestrationUseCase).GetTypeInfo().Assembly);
            return services;
        }
    }
}
