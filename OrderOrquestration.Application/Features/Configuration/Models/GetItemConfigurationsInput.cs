using MediatR;
using OrderOrquestration.Application.Shared.Domain.Entities;
using OrderOrquestration.Application.Shared.Domain.Models;

namespace OrderOrquestration.Application.Features.Configuration.Models
{
    public class GetItemConfigurationsInput :IRequest<Output<List<ItemConfiguration>>>
    {
    }
}
