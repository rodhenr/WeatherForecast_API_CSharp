using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public class ForecastForecastday
{
    public ForecastForecastday(DateTime date, int dateEpoch, ForecastDay day, ForecastAstro astro, List<ForecastHour> hour)
    {
        Date = date;
        DateEpoch = dateEpoch;
        Day = day;
        Astro = astro;
        Hour = hour;
    }

    public DateTime Date { get; set; }

    [JsonPropertyName("date_epoch")]
    public int DateEpoch { get; set; }

    public ForecastDay Day { get; set; }

    public ForecastAstro Astro { get; set; }

    public List<ForecastHour> Hour { get; set; }
}
