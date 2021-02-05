using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Logistics.Data.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Logistics.Client.React.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogisticsController : Controller
    {
        private readonly IHttpClientFactory factory;

        public LogisticsController(IHttpClientFactory factory)
        {
            this.factory = factory;
        }

        [HttpPost]
        [Route("Generate")]
        //[Produces("application/json")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<BoxDto>))]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Generate()
        {
            var client = factory.CreateClient("logistics");
            var result = await client.PostAsync("api/Shipping/Generate", null);

            if (!result.IsSuccessStatusCode)
                return StatusCode(500);

            var json = await result.Content.ReadAsStringAsync();
            var items = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BoxItemDto>>(json);

            return Ok(items);
        }
    }
}
