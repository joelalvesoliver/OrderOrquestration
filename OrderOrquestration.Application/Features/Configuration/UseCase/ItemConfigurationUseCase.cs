using MediatR;
using OrderOrquestration.Application.Features.Configuration.Models;
using OrderOrquestration.Application.Shared.Domain.Contracts;
using OrderOrquestration.Application.Shared.Domain.Entities;
using OrderOrquestration.Application.Shared.Domain.Models;

namespace OrderOrquestration.Application.Features.Configuration.UseCase
{
    public class ItemConfigurationUseCase : IRequestHandler<ItemConfigurationInput, Output<bool>>
    {
        private readonly IOrderOrquestrationRepository _orderOrquestrationRepository;

        public ItemConfigurationUseCase(IOrderOrquestrationRepository orderOrquestrationRepository)
        {
            _orderOrquestrationRepository = orderOrquestrationRepository;
        }

        public async Task<Output<bool>> Handle(ItemConfigurationInput request, CancellationToken cancellationToken)
        {
            var action = await _orderOrquestrationRepository.GetActionConfigurationByIdAsync(request.ActionId, cancellationToken);
            if(action == null)
            {
                throw new Exception("Invalid ActionId");
            }

            var itemConfiguration = new ItemConfiguration
            {
                ActionId = request.ActionId,
                Product = request.Product,
            };

            var result = await _orderOrquestrationRepository.CreateItemConfigurationAsync(itemConfiguration, cancellationToken);
            return new Output<bool>(result);
        }
    }
}
