using OrderOrquestration.Application.Shared.Strategies.Contracts;

namespace OrderOrquestration.Application.Shared.Strategies
{
    public class RemittanceService : IActionStrategy
    {
        public void Execute(string product)
        {
            Console.WriteLine("Criando remessa para o produto " + product);
        }
    }
}
