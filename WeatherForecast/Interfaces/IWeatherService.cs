using WeatherForecast.DTOs;

namespace WeatherForecast.Interfaces;

public interface IWeatherService
{
    public Task<WeatherDTO> GetCityWeatherInfo(string city);
}
