using OrderOrquestration.Application.Shared.Strategies.Contracts;

namespace OrderOrquestration.Application.Shared.Strategies
{
    public class SpecificMidiaService : IActionStrategy
    {
        public void Execute(string product)
        {
            Console.WriteLine("Adiciona videos especifico na remessa");
        }
    }
}
