using MediatR;
using OrderOrquestration.Application.Shared.Domain.Models;

namespace OrderOrquestration.Application.Features.Configuration.Models
{
    public class ActionConfigurationInput : IRequest<Output<bool>>
    {
        public string Description { get; set; }
    }
}
