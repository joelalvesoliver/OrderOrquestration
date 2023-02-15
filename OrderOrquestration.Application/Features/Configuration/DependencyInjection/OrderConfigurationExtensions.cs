using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OrderOrquestration.Application.Features.Configuration.UseCase;
using System.Reflection;

namespace OrderOrquestration.Application.Features.Configuration.DependencyInjection
{
    public static class OrderConfigurationExtensions
    {
        public static IServiceCollection AddOrderConfigurationExtensions(this IServiceCollection services) =>
              services
                  .AddMediatRExtensions();

        private static IServiceCollection AddMediatRExtensions(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ActionConfigurationUseCase).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetActionsConfigurationUseCase).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetItemConfigurationsUseCase).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(ItemConfigurationUseCase).GetTypeInfo().Assembly);
            
            return services;
        }
    }
}
