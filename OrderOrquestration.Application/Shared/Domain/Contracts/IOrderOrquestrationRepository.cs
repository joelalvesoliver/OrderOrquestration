using OrderOrquestration.Application.Shared.Domain.Entities;

namespace OrderOrquestration.Application.Shared.Domain.Contracts
{
    public interface IOrderOrquestrationRepository
    {
        Task<bool> CreateActionAsync(ActionConfiguration action, CancellationToken cancellationToken);
        Task<List<ActionConfiguration>> GetActionsAsync(CancellationToken cancellationToken);
        Task<ActionConfiguration> GetActionConfigurationByIdAsync(int actionId, CancellationToken cancellationToken);

        Task<bool> CreateItemConfigurationAsync(ItemConfiguration item, CancellationToken cancellationToken);
        Task<List<ItemConfiguration>> GetItemConfigurationsAsync(CancellationToken cancellationToken);
        Task<ItemConfiguration> GetItemConfigurationByProductAsync(string product, CancellationToken cancellationToken);

    }
}
