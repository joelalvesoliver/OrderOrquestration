using MediatR;
using OrderOrquestration.Application.Shared.Domain.Entities;
using OrderOrquestration.Application.Shared.Domain.Models;

namespace OrderOrquestration.Application.Features.Configuration.Models
{
    public class GetActionsConfigurationInput : IRequest<Output<List<ActionConfiguration>>>
    {
    }
}
