using MediatR;
using OrderOrquestration.Application.Features.Configuration.Models;
using OrderOrquestration.Application.Shared.Domain.Contracts;
using OrderOrquestration.Application.Shared.Domain.Entities;
using OrderOrquestration.Application.Shared.Domain.Models;

namespace OrderOrquestration.Application.Features.Configuration.UseCase
{
    public class GetItemConfigurationsUseCase : IRequestHandler<GetItemConfigurationsInput, Output<List<ItemConfiguration>>>
    {
        private readonly IOrderOrquestrationRepository _orderOrquestrationRepository;

        public GetItemConfigurationsUseCase(IOrderOrquestrationRepository orderOrquestrationRepository)
        {
            _orderOrquestrationRepository = orderOrquestrationRepository;
        }

        public async Task<Output<List<ItemConfiguration>>> Handle(GetItemConfigurationsInput request, CancellationToken cancellationToken)
        {
            var result = await _orderOrquestrationRepository.GetItemConfigurationsAsync(cancellationToken);
            return new Output<List<ItemConfiguration>>(result ?? new List<ItemConfiguration>());
        }
    }
}
