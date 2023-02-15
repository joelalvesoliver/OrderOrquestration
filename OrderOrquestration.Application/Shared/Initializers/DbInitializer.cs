using OrderOrquestration.Application.Shared.Context;

namespace OrderOrquestration.Application.Shared.Initializers
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
