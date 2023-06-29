using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public partial class Location
{
    public Location(string? name = default, string? region = default, string? country = default, decimal lat = default, decimal lon = default, string? tzId = default, int localtimeEpoch = default, string? localtime = default)
    {
        Name = name;
        Region = region;
        Country = country;
        Lat = lat;
        Lon = lon;
        TzId = tzId;
        LocaltimeEpoch = localtimeEpoch;
        Localtime = localtime;
    }

    public string? Name { get; set; }

    public string? Region { get; set; }

    public string? Country { get; set; }

    public decimal Lat { get; set; }

    public decimal Lon { get; set; }

    [JsonPropertyName("tz_id")]
    public string? TzId { get; set; }

    [JsonPropertyName("localtime_epoch")]
    public int LocaltimeEpoch { get; set; }

    public string? Localtime { get; set; }
}
