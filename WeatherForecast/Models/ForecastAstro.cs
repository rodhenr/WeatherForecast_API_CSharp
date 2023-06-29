using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public class ForecastAstro
{
    public ForecastAstro(string? sunrise = default, string? sunset = default, string? moonrise = default, string? moonset = default, string? moonPhase = default, string? moonIllumination = default, int isMoonUp = default, int isSunUp = default)
    {
        Sunrise = sunrise;
        Sunset = sunset;
        Moonrise = moonrise;
        Moonset = moonset;
        MoonPhase = moonPhase;
        MoonIllumination = moonIllumination;
        IsMoonUp = isMoonUp;
        IsSunUp = isSunUp;
    }

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
