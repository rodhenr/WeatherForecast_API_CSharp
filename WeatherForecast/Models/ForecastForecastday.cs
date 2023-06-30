using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public class ForecastForecastday
{
    public DateTime? Date { get; set; }

    [JsonPropertyName("date_epoch")]
    public int DateEpoch { get; set; }

    public ForecastDay? Day { get; set; }

    public ForecastAstro? Astro { get; set; }

    public List<ForecastHour>? Hour { get; set; }
}
