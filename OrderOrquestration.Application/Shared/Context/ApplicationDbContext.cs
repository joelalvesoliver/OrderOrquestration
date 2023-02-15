using Microsoft.EntityFrameworkCore;
using OrderOrquestration.Application.Shared.Domain.Entities;
using ActionConfiguration = OrderOrquestration.Application.Shared.Domain.Entities.ActionConfiguration;

namespace OrderOrquestration.Application.Shared.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ItemConfiguration> ItemConfigurations { get; set; }
        public DbSet<ActionConfiguration> Actions { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
