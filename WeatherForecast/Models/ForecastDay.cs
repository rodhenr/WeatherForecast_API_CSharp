using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public class ForecastDay
{
    public ForecastDay(decimal maxtempC, decimal maxtempF, decimal mintempC, decimal mintempF, decimal avgtempC, decimal avgtempF, decimal maxwindMph, decimal maxwindKph, decimal totalprecipMm, decimal totalprecipIn, decimal avgvisKm, decimal avgvisMiles, decimal avghumidity, int dailyWillItRain, int dailyChanceOfRain, int dailyWillItSnow, int dailyChanceOfSnow, ForecastDayCondition condition, decimal uv)
    {
        MaxtempC = maxtempC;
        MaxtempF = maxtempF;
        MintempC = mintempC;
        MintempF = mintempF;
        AvgtempC = avgtempC;
        AvgtempF = avgtempF;
        MaxwindMph = maxwindMph;
        MaxwindKph = maxwindKph;
        TotalprecipMm = totalprecipMm;
        TotalprecipIn = totalprecipIn;
        AvgvisKm = avgvisKm;
        AvgvisMiles = avgvisMiles;
        Avghumidity = avghumidity;
        DailyWillItRain = dailyWillItRain;
        DailyChanceOfRain = dailyChanceOfRain;
        DailyWillItSnow = dailyWillItSnow;
        DailyChanceOfSnow = dailyChanceOfSnow;
        Condition = condition;
        Uv = uv;
    }

    [JsonPropertyName("maxtemp_c")]
    public decimal MaxtempC { get; set; }

    [JsonPropertyName("maxtemp_f")]
    public decimal MaxtempF { get; set; }

    [JsonPropertyName("mintemp_c")]
    public decimal MintempC { get; set; }

    [JsonPropertyName("mintemp_f")]
    public decimal MintempF { get; set; }

    [JsonPropertyName("avgtemp_c")]
    public decimal AvgtempC { get; set; }

    [JsonPropertyName("avgtemp_f")]
    public decimal AvgtempF { get; set; }

    [JsonPropertyName("maxwind_mph")]
    public decimal MaxwindMph { get; set; }

    [JsonPropertyName("maxwind_kph")]
    public decimal MaxwindKph { get; set; }

    [JsonPropertyName("totalprecip_mm")]
    public decimal TotalprecipMm { get; set; }

    [JsonPropertyName("totalprecip_in")]
    public decimal TotalprecipIn { get; set; }

    [JsonPropertyName("avgvis_km")]
    public decimal AvgvisKm { get; set; }

    [JsonPropertyName("avgvis_miles")]
    public decimal AvgvisMiles { get; set; }

    public decimal Avghumidity { get; set; }

    [JsonPropertyName("daily_will_it_rain")]
    public int DailyWillItRain { get; set; }

    [JsonPropertyName("daily_chance_of_rain")]
    public int DailyChanceOfRain { get; set; }

    [JsonPropertyName("daily_will_it_snow")]
    public int DailyWillItSnow { get; set; }

    [JsonPropertyName("daily_chance_of_snow")]
    public int DailyChanceOfSnow { get; set; }

    public ForecastDayCondition Condition { get; set; }

    public decimal Uv { get; set; }
}

