using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderOrquestration.Application.Features.Configuration.Models;
using OrderOrquestration.Application.Shared.Domain.Entities;
using OrderOrquestration.Application.Shared.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace OrderOrquestration.WebApi.Controllers
{
    public class OrderConfigurationController : Controller
    {
        private ILogger<OrderConfigurationController> _logger;
        private readonly IMediator _mediator;

        public OrderConfigurationController(ILogger<OrderConfigurationController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost("/action")]
        [ProducesResponseType(typeof(Output<bool>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateActionsConfigurationAsync([FromBody][Required] ActionConfigurationInput input, CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _mediator.Send(input, cancellationToken));
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet("/actions")]
        [ProducesResponseType(typeof(Output<List<ActionConfiguration>>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetActionsConfigurationAsync(CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _mediator.Send(new GetActionsConfigurationInput(), cancellationToken));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpPost("/item-configuration")]
        [ProducesResponseType(typeof(Output<bool>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateItemConfigurationAsync([FromBody][Required] ItemConfigurationInput input, CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _mediator.Send(input, cancellationToken));
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet("/itens-configuration")]
        [ProducesResponseType(typeof(Output<List<ItemConfiguration>>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetItemConfigurationAsync(CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _mediator.Send(new GetItemConfigurationsInput(), cancellationToken));
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
