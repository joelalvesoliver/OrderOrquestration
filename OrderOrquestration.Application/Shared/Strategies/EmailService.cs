using OrderOrquestration.Application.Shared.Strategies.Contracts;

namespace OrderOrquestration.Application.Shared.Strategies
{
    public class EmailService : IActionStrategy
    {
        public void Execute(string product)
        {
            Console.WriteLine("Enviando email referente ao produto " + product);
        }
    }
}
