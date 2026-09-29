using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shipit.PriceQuotes.Api.Controllers
{
    [Route("pricequote")]
    [ApiController]
    public class PriceQuoteController : ControllerBase
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello";
        }
    }
}
