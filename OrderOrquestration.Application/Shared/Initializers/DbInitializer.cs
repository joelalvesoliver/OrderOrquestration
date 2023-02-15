using OrderOrquestration.Application.Shared.Context;
using OrderOrquestration.Application.Shared.Domain.Entities;

namespace OrderOrquestration.Application.Shared.Initializers
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            context.Actions.Add(new ActionConfiguration { Description = "Enviar E-mail" });
            context.Actions.Add(new ActionConfiguration { Description = "Criar remessa" });
            context.Actions.Add(new ActionConfiguration { Description = "Criar remessa duplicada" });
            context.Actions.Add(new ActionConfiguration { Description = "Comissao agente" });
            context.Actions.Add(new ActionConfiguration { Description = "Upgrade associação" });
            context.Actions.Add(new ActionConfiguration { Description = "Criar associação" });

            context.ItemConfigurations.Add(new ItemConfiguration { ActionId = 1, Product = "Livro" });
            context.ItemConfigurations.Add(new ItemConfiguration { ActionId = 5, Product = "upgrade associação" });
            context.ItemConfigurations.Add(new ItemConfiguration { ActionId = 1, Product = "upgrade associação" });
            context.ItemConfigurations.Add(new ItemConfiguration { ActionId = 6, Product = "criar associacao" });
            context.ItemConfigurations.Add(new ItemConfiguration { ActionId = 1, Product = "criar associacao" });
            context.ItemConfigurations.Add(new ItemConfiguration { ActionId = 4, Product = "livro" });

            context.SaveChanges();
        }
    }
}
