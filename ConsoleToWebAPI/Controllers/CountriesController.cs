using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpPost("")]
        public IActionResult AddCountry(CountryModel country)
        {
            return Ok($"{country.Name} {country.Area} {country.Population}");
        }
    }
}
