using Microsoft.AspNetCore.Mvc;
using Covert.Dragon.Domain.Catalog;
using Covert.Dragon.Data;


namespace Covert.Dragon.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world.");
        }

    }
}