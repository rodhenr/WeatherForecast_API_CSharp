﻿using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public class Forecast
{
    public Forecast(List<ForecastForecastday>  forecastday)
    {
        Forecastday = forecastday;
    }

    [JsonPropertyName("forecastday")]
    public List<ForecastForecastday> Forecastday { get; set; }
}
