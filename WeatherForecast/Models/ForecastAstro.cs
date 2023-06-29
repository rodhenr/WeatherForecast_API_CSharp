using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public class ForecastAstro
{
    public string? Sunrise { get; set; }

    public string? Sunset { get; set; }

    public string? Moonrise { get; set; }

    public string? Moonset { get; set; }

    [JsonPropertyName("moon_phase")]
    public string? MoonPhase { get; set; }

    [JsonPropertyName("moon_illumination")]
    public string? MoonIllumination { get; set; }

    [JsonPropertyName("is_moon_up")]
    public int IsMoonUp { get; set; }

    [JsonPropertyName("is_sun_up")]
    public int IsSunUp { get; set; }
}
