using Microsoft.EntityFrameworkCore;
using OrderOrquestration.Application.Shared.Context;
using OrderOrquestration.Application.Shared.Domain.Contracts;
using OrderOrquestration.Application.Shared.Domain.Entities;

namespace OrderOrquestration.Application.Shared.Repositories
{
    public class OrderOrquestrationRepository : IOrderOrquestrationRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderOrquestrationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateActionAsync(ActionConfiguration action, CancellationToken cancellationToken)
        {
            _context.Actions.Add(action);
            return (await _context.SaveChangesAsync(cancellationToken)) > 0;
        }

        public async Task<bool> CreateItemConfigurationAsync(ItemConfiguration item, CancellationToken cancellationToken)
        {
            _context.ItemConfigurations.Add(item);
            return (await _context.SaveChangesAsync(cancellationToken)) > 0;
        }

        public async Task<ActionConfiguration> GetActionConfigurationByIdAsync(int actionId, CancellationToken cancellationToken)
        {
            return await _context.Actions.Where(e => e.Id == actionId).FirstOrDefaultAsync(cancellationToken: cancellationToken);
        }

        public async Task<List<ActionConfiguration>> GetActionsAsync(CancellationToken cancellationToken)
        {
            return await _context.Actions
                        .ToListAsync(cancellationToken);
        }

        public async Task<List<ItemConfiguration>> GetItemConfigurationByProductAsync(string product, CancellationToken cancellationToken)
        {
            return await _context.ItemConfigurations.Where(e => e.Product == product).ToListAsync(cancellationToken);
        }

        public async Task<List<ItemConfiguration>> GetItemConfigurationsAsync(CancellationToken cancellationToken)
        {
            return await _context.ItemConfigurations
                        .ToListAsync(cancellationToken);
        }
    }
}
