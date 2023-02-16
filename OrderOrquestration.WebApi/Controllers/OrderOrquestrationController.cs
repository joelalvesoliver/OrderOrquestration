using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderOrquestration.Application.Features.OrderOrquestration.Models;
using OrderOrquestration.Application.Shared.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace OrderOrquestration.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class OrderOrquestrationController : Controller  
    {
        private ILogger<OrderOrquestrationController> _logger;
        private readonly IMediator _mediator;

        public OrderOrquestrationController(ILogger<OrderOrquestrationController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        /// <summary>
        /// Recebe a comunicação de um pagamento e então processa as ações de acordo com as especificações e regras do produto envolvido.
        /// </summary>
        /// <param name="productOrder"> produto envovido no pagamento</param>
        /// <response code="200">Retorna o status do processamento das ações</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost()]
        [ProducesResponseType(typeof(Output<string>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> OrderOrquestrationControllerAsync([FromQuery][Required] string productOrder, CancellationToken cancellationToken)
        {
            try
            {
                var input = new OrderOrquestrationInput(productOrder);
                return Ok(await _mediator.Send(input, cancellationToken));
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
