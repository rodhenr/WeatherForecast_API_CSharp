using Microsoft.AspNetCore.Mvc;
using WeatherForecast.DTOs;
using WeatherForecast.Exceptions;
using WeatherForecast.Interfaces;

namespace WeatherForecast.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<ActionResult<WeatherDTO>> SearchByCity(string city)
        {
            try
            {
                WeatherDTO content = await _weatherService.GetCityWeatherInfo(city);

                return Ok(content);
            }
            catch (InvalidApiKeyException ex)
            {
                return StatusCode(500, ex.Message);
            }
            catch (RequestFailedException ex)
            {
                return StatusCode(400, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

