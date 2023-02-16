using OrderOrquestration.Application.Shared.Strategies.Contracts;

namespace OrderOrquestration.Application.Shared.Strategies
{
    public class AssociateService : IActionStrategy
    {
        public void Execute(string product)
        {
            Console.WriteLine("Associação criada");
        }
    }
}
