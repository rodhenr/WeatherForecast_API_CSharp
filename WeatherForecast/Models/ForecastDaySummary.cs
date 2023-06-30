using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public class ForecastDaySummary
{
    public DateTime? Date { get; set; }
    public decimal MaxTempCelsius { get; set; }

    public decimal MinTempCelsius { get; set; }

    public decimal MaxTempFahrenheit { get; set; }

    public decimal MinTempFahrenheit { get; set; }

    public decimal TotalPrecipitationMm { get; set; }
    public string? Condition { get; set; }
}
