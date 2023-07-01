using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public class Current
{
    public Current(int lastUpdatedEpoch, string lastUpdated, decimal tempC, decimal tempF, int isDay, CurrentCondition condition, decimal windMph, decimal windKph, int windDegree, string windDir, decimal pressureMb, decimal pressureIn, decimal precipMm, decimal precipIn, int humidity, int cloud, decimal feelslikeC, decimal feelslikeF, decimal visKm, decimal visMiles, decimal uv, decimal gustMph, decimal gustKph)
    {
        LastUpdatedEpoch = lastUpdatedEpoch;
        LastUpdated = lastUpdated;
        TempC = tempC;
        TempF = tempF;
        IsDay = isDay;
        Condition = condition;
        WindMph = windMph;
        WindKph = windKph;
        WindDegree = windDegree;
        WindDir = windDir;
        PressureMb = pressureMb;
        PressureIn = pressureIn;
        PrecipMm = precipMm;
        PrecipIn = precipIn;
        Humidity = humidity;
        Cloud = cloud;
        FeelslikeC = feelslikeC;
        FeelslikeF = feelslikeF;
        VisKm = visKm;
        VisMiles = visMiles;
        Uv = uv;
        GustMph = gustMph;
        GustKph = gustKph;
    }

    [JsonPropertyName("last_updated_epoch")]
    public int LastUpdatedEpoch { get; set; }

    [JsonPropertyName("last_updated")]
    public string LastUpdated { get; set; }

    [JsonPropertyName("temp_c")]
    public decimal TempC { get; set; }

    [JsonPropertyName("temp_f")]
    public decimal TempF { get; set; }

    [JsonPropertyName("is_day")]
    public int IsDay { get; set; }

    public CurrentCondition Condition { get; set; }

    [JsonPropertyName("wind_mph")]
    public decimal WindMph { get; set; }

    [JsonPropertyName("wind_kph")]
    public decimal WindKph { get; set; }

    [JsonPropertyName("wind_degree")]
    public int WindDegree { get; set; }

    [JsonPropertyName("wind_dir")]
    public string WindDir { get; set; }

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

    [JsonPropertyName("vis_km")]
    public decimal VisKm { get; set; }

    [JsonPropertyName("vis_miles")]
    public decimal VisMiles { get; set; }

    public decimal Uv { get; set; }

    [JsonPropertyName("gust_mph")]
    public decimal GustMph { get; set; }

    [JsonPropertyName("gust_kph")]
    public decimal GustKph { get; set; }
}
