using MediatR;
using Microsoft.Extensions.Logging;
using OrderOrquestration.Application.Features.OrderOrquestration.Models;
using OrderOrquestration.Application.Shared.Domain.Contracts;
using OrderOrquestration.Application.Shared.Domain.Models;

namespace OrderOrquestration.Application.Features.OrderOrquestration.UseCase
{
    public class OrderOrquestrationUseCase : IRequestHandler<OrderOrquestrationInput, Output<string>>
    {
        private readonly IOrderOrquestration _orderOrquestration;
        private readonly ILogger<OrderOrquestrationUseCase> _logger;

        public OrderOrquestrationUseCase(IOrderOrquestration orderOrquestration, ILogger<OrderOrquestrationUseCase> logger)
        {
            _orderOrquestration = orderOrquestration;
            _logger = logger;
        }

        public Task<Output<string>> Handle(OrderOrquestrationInput request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
