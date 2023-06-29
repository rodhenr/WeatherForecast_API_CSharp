using AutoMapper;
using dotenv.net;
using WeatherForecast.DTOs;
using WeatherForecast.Exceptions;
using WeatherForecast.Interfaces;
using WeatherForecast.Models;

namespace WeatherForecast.Services;

public class WeatherService : IWeatherService
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly IMapper _mapper;
    private readonly string? ApiKey;

    public WeatherService(IHttpClientFactory httpClientFactory, IMapper mapper)
    {
        DotEnv.Load();

        _mapper = mapper;
        _clientFactory = httpClientFactory;
        ApiKey = Environment.GetEnvironmentVariable("API_KEY");
    }

    public async Task<WeatherDTO> GetCityWeatherInfo(string city)
    {
        var client = _clientFactory.CreateClient();

        if (ApiKey == null)
        {
            throw new InvalidApiKeyException("Invalid API key");
        }

        string url = $"https://api.weatherapi.com/v1/forecast.json?key={ApiKey}&q={city}&days=6&aqi=no&alerts=no";

        HttpResponseMessage response = await client.GetAsync(url);

        if (!response.IsSuccessStatusCode)
        {
            throw new RequestFailedException($"Invalid request response: {response.StatusCode}");
        }

        Weather? content = await response.Content.ReadFromJsonAsync<Weather>();


        if(content == null)
        {
            throw new NullRequestException("The request returned NULL");
        }

        return _mapper.Map<WeatherDTO>(content);
    }
}
