using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace WeatherForecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IHttpClientFactory _clientFactory;

        public WeatherForecastController(IHttpClientFactory httpClientFactory)
        {
            _clientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<ActionResult<WeatherForecast>> Search()
        {
            var client = _clientFactory.CreateClient();
            HttpResponseMessage response = await client.GetAsync("https://catfact.ninja/fact");

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                WeatherForecast responseObject = JsonSerializer.Deserialize<WeatherForecast>(content)!;

                return responseObject;
            }

            return NotFound();
        }
    }
}