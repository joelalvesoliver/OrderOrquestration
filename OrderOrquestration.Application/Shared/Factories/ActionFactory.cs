using OrderOrquestration.Application.Shared.Factories.Contracts;
using OrderOrquestration.Application.Shared.Strategies;
using OrderOrquestration.Application.Shared.Strategies.Contracts;

namespace OrderOrquestration.Application.Shared.Factories
{
    public class ActionFactory : IActionFactory
    {
        public IActionStrategy SetStrategy(int strategyId)
        {
            switch (strategyId)
            {
                case 1: return new EmailService();
                case 2: return new RemittanceService();
                case 3: return new DuplicatedRemittanceService();
                case 4: return new CommissionService();
                case 5: return new UpdateAssociationService();
                case 6: return new AssociateService();
                case 7: return new SpecificMidiaService();
                default:
                    throw new ArgumentException("Strategy not implemented");
            }
        }
    }
}
