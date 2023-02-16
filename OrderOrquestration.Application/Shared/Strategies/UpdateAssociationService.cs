using OrderOrquestration.Application.Shared.Strategies.Contracts;

namespace OrderOrquestration.Application.Shared.Strategies
{
    public class UpdateAssociationService : IActionStrategy
    {
        public void Execute(string product)
        {
            Console.WriteLine("Update da associação realizado");
        }
    }
}
