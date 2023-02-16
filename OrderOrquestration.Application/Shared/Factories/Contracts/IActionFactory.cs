using OrderOrquestration.Application.Shared.Strategies.Contracts;

namespace OrderOrquestration.Application.Shared.Factories.Contracts
{
    public interface IActionFactory
    {
        IActionStrategy SetStrategy(int strategyId);
    }
}
