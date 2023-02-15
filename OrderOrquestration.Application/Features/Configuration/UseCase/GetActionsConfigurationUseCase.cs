using MediatR;
using OrderOrquestration.Application.Features.Configuration.Models;
using OrderOrquestration.Application.Shared.Domain.Contracts;
using OrderOrquestration.Application.Shared.Domain.Entities;
using OrderOrquestration.Application.Shared.Domain.Models;

namespace OrderOrquestration.Application.Features.Configuration.UseCase
{
    public class GetActionsConfigurationUseCase : IRequestHandler<GetActionsConfigurationInput, Output<List<ActionConfiguration>>>
    {
        private readonly IOrderOrquestrationRepository _orderOrquestrationRepository;

        public GetActionsConfigurationUseCase(IOrderOrquestrationRepository orderOrquestrationRepository)
        {
            _orderOrquestrationRepository = orderOrquestrationRepository;
        }

        public async Task<Output<List<ActionConfiguration>>> Handle(GetActionsConfigurationInput request, CancellationToken cancellationToken)
        {
            var result = await _orderOrquestrationRepository.GetActionsAsync(cancellationToken);
            return new Output<List<ActionConfiguration>>(result?? new List<ActionConfiguration>());
        }
    }
}
