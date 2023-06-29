using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public class ForecastHour
{
    [JsonPropertyName("time_epoch")]
    public int TimeEpoch { get; set; }

    public string? Time { get; set; }

    [JsonPropertyName("temp_c")]
    public decimal TempC { get; set; }

    [JsonPropertyName("temp_f")]
    public decimal TempF { get; set; }

    [JsonPropertyName("is_day")]
    public int IsDay { get; set; }

    public ForecastCondition? Condition { get; set; }

    [JsonPropertyName("wind_mph")]
    public decimal WindMph { get; set; }

    [JsonPropertyName("wind_kph")]
    public decimal WindKph { get; set; }

    [JsonPropertyName("wind_degree")]
    public int WindDegree { get; set; }

    [JsonPropertyName("wind_dir")]
    public string? WindDir { get; set; }

    [JsonPropertyName("pressure_mb")]
    public decimal PressureMb { get; set; }

    [JsonPropertyName("pressure_in")]
    public decimal PressureIn { get; set; }

    [JsonPropertyName("precip_mm")]
    public decimal PrecipMm { get; set; }

    [JsonPropertyName("precip_in")]
    public decimal PrecipIn { get; set; }

    public int Humidity { get; set; }

    public int Cloud { get; set; }

    [JsonPropertyName("feelslike_c")]
    public decimal FeelslikeC { get; set; }

    [JsonPropertyName("feelslike_f")]
    public decimal FeelslikeF { get; set; }

    [JsonPropertyName("windchill_c")]
    public decimal WindchillC { get; set; }

    [JsonPropertyName("windchill_f")]
    public decimal WindchillF { get; set; }

    [JsonPropertyName("heatindex_c")]
    public decimal HeatindexC { get; set; }

    [JsonPropertyName("heatindex_f")]
    public decimal HeatindexF { get; set; }

    [JsonPropertyName("dewpoint_c")]
    public decimal DewpointC { get; set; }

    [JsonPropertyName("dewpoint_f")]
    public decimal DewpointF { get; set; }

    [JsonPropertyName("will_it_rain")]
    public int WillItRain { get; set; }

    [JsonPropertyName("chance_of_rain")]
    public int ChanceOfRain { get; set; }

    [JsonPropertyName("will_it_snow")]
    public int WillItSnow { get; set; }

    [JsonPropertyName("chance_of_snow")]
    public int ChanceOfSnow { get; set; }

    [JsonPropertyName("vis_km")]
    public decimal VisKm { get; set; }

    [JsonPropertyName("vis_miles")]
    public decimal VisMiles { get; set; }

    [JsonPropertyName("tgust_mph")]
    public decimal GustMph { get; set; }

    [JsonPropertyName("gust_kph")]
    public decimal GustKph { get; set; }

    public decimal Uv { get; set; }
}
