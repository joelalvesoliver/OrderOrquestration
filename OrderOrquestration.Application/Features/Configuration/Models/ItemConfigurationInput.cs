using MediatR;
using OrderOrquestration.Application.Shared.Domain.Models;

namespace OrderOrquestration.Application.Features.Configuration.Models
{
    public class ItemConfigurationInput : IRequest<Output<bool>>
    {
        public string Product { get; set; }
        public int ActionId { get; set; }
    }
}
