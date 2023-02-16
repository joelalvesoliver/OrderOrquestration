using OrderOrquestration.Application.Shared.Strategies.Contracts;

namespace OrderOrquestration.Application.Shared.Strategies
{
    public class CommissionService : IActionStrategy
    {
        public void Execute(string product)
        {
            Console.WriteLine("Pagando comissão referente ao produto " +product);
        }
    }
}
