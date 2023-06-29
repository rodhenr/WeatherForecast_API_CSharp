using Microsoft.AspNetCore.Mvc;
using dotenv;
using WeatherForecast.Models;
using dotenv.net;

namespace WeatherForecast.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public WeatherForecastController(IHttpClientFactory httpClientFactory)
        {
            _clientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<ActionResult<Weather>> SearchByCity(string city)
        {
            DotEnv.Load();
            string? apiKey = Environment.GetEnvironmentVariable("API_KEY");

            var client = _clientFactory.CreateClient();

            if (apiKey == null)
            {
                return NotFound();
            }

            string url = $"https://api.weatherapi.com/v1/forecast.json?key={apiKey}&q={city}&days=6&aqi=no&alerts=no";
            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            Weather? content = await response.Content.ReadFromJsonAsync<Weather>();

            return content == null ? NotFound() : content;
        }
    }
}
//Ler de .env
//Como criar arquivos? (Direto no projeto e pelo terminal)
//ba128039c8a2493884f174647232806
//https://api.weatherapi.com/v1/forecast.json?$key=ba128039c8a2493884f174647232806&q=Divinopolis&days=6&aqi=no&alerts=no
//https://api.weatherapi.com/v1/forecast.json?key=ba128039c8a2493884f174647232806&q=divinopolis&days=6&aqi=no&alerts=no