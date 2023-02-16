using MediatR;
using OrderOrquestration.Application.Shared.Domain.Models;

namespace OrderOrquestration.Application.Features.OrderOrquestration.Models
{
    public class OrderOrquestrationInput : IRequest<Output<string>>
    {
        public OrderOrquestrationInput(string product)
        {
            ProductOrder = product;
        }
        public string ProductOrder { get;}
    }
}
