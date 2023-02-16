using MediatR;
using Microsoft.Extensions.Logging;
using OrderOrquestration.Application.Features.OrderOrquestration.Models;
using OrderOrquestration.Application.Shared.Domain.Contracts;
using OrderOrquestration.Application.Shared.Domain.Models;
using OrderOrquestration.Application.Shared.Factories;

namespace OrderOrquestration.Application.Features.OrderOrquestration.UseCase
{
    public class OrderOrquestrationUseCase : IRequestHandler<OrderOrquestrationInput, Output<string>>
    {
        private readonly IOrderOrquestrationRepository _orderOrquestration;

        public OrderOrquestrationUseCase(IOrderOrquestrationRepository orderOrquestration)
        {
            _orderOrquestration = orderOrquestration;
        }

        public async Task<Output<string>> Handle(OrderOrquestrationInput request, CancellationToken cancellationToken)
        {
            var itemConfigurations = await _orderOrquestration.GetItemConfigurationByProductAsync(request.ProductOrder, cancellationToken);
            if (itemConfigurations.Count == 0)
                throw new Exception("Invalid configuration for this product");

            var factory = new ActionFactory();
            foreach(var itemConfig in itemConfigurations)
            {
                var strategy = factory.SetStrategy(itemConfig.ActionId);
                strategy.Execute(request.ProductOrder);
            }

            return new Output<string>("Processamento realizado com sucesso");
        }
    }
}
