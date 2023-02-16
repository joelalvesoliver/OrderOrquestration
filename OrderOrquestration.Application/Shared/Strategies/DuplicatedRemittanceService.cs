using OrderOrquestration.Application.Shared.Strategies.Contracts;

namespace OrderOrquestration.Application.Shared.Strategies
{
    public class DuplicatedRemittanceService : IActionStrategy
    {
        public void Execute(string product)
        {
            Console.WriteLine("Criando remessa duplicada para o produto "+ product);
        }
    }
}
