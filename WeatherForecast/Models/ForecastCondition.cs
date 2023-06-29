namespace WeatherForecast.Models;

public class ForecastCondition
{
    public ForecastCondition(string? text = default, string? icon = default, int? code = default)
    {
        Text = text;
        Icon = icon;
        Code = code;
    }

    public string? Text { get; set; }

    public string? Icon { get; set; }

    public int? Code { get; set; }
}
