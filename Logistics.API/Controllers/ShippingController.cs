using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logistics.Business.Commands.ShippingCommands;
using Logistics.Business.Core.Interfaces.Commands;
using Logistics.Business.Core.Interfaces.Queries;
using Logistics.Business.Queries.ShippingQueries;
using Logistics.Data.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Logistics.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ShippingController : Controller
    {
        private readonly ICommandBus commandBus;
        private readonly IQueryProcessor queryProcessor;

        public ShippingController(ICommandBus commandBus, IQueryProcessor queryProcessor)
        {
            this.commandBus = commandBus;
            this.queryProcessor = queryProcessor;
        }

        [HttpPost]
        [Route("Generate")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<BoxDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Generate()
        {
            var command = new GenerateShipmentItems { };
            await commandBus.SendAsync(command);

            if (!command.Result)
                return StatusCode(500);

            var query = new GetShipmentItems { };
            var result = await queryProcessor.ProcessAsync(query);

            if(result == null || !result.Any())
                return StatusCode(500);

            return Ok(result);
        }
    }
}
