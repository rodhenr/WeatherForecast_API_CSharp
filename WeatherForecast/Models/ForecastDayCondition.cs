namespace WeatherForecast.Models;

public class ForecastDayCondition
{
    public ForecastDayCondition(string text, string icon, int code)
    {
        Text = text;
        Icon = icon;
        Code = code;
    }

    public string Text { get; set; }

    public string Icon { get; set; }

    public int Code { get; set; }
}
