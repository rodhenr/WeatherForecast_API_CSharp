namespace WeatherForecast.Models;

public class Weather
{
    public Weather(Location location, Current current, Forecast forecast)
    {
        Location = location;
        Current = current;
        Forecast = forecast;
    }

    public Location Location { get; set; }

    public Current Current { get; set; }

    public Forecast Forecast { get; set; }
}
