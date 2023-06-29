using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public class ForecastForecastday
{
    public ForecastForecastday(DateTime? date = default, int dateEpoch = default, ForecastDay? day = default, ForecastAstro? astro = default, List<ForecastHour>? hour = default)
    {
        Date = date;
        DateEpoch = dateEpoch;
        Day = day;
        Astro = astro;
        Hour = hour;

    }

    public DateTime? Date { get; set; }

    [JsonPropertyName("date_epoch")]
    public int DateEpoch { get; set; }

    public ForecastDay? Day { get; set; }

    public ForecastAstro? Astro { get; set; }

    public List<ForecastHour>? Hour { get; set; }


}
