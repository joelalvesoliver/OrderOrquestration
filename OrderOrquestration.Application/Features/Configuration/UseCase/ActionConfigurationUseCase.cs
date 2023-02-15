using MediatR;
using OrderOrquestration.Application.Features.Configuration.Models;
using OrderOrquestration.Application.Shared.Domain.Contracts;
using OrderOrquestration.Application.Shared.Domain.Entities;
using OrderOrquestration.Application.Shared.Domain.Models;

namespace OrderOrquestration.Application.Features.Configuration.UseCase
{
    public class ActionConfigurationUseCase : IRequestHandler<ActionConfigurationInput, Output<bool>>
    {
        private readonly IOrderOrquestrationRepository _orderOrquestrationRepository;

        public ActionConfigurationUseCase(IOrderOrquestrationRepository orderOrquestrationRepository)
        {
            _orderOrquestrationRepository = orderOrquestrationRepository;
        }

        public async Task<Output<bool>> Handle(ActionConfigurationInput request, CancellationToken cancellationToken)
        {
            var action = new ActionConfiguration
            {
                Description = request.Description
            };

            var result = await _orderOrquestrationRepository.CreateActionAsync(action, cancellationToken);

            return new Output<bool>(result);
        }
    }
}
