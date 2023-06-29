using System.Text.Json.Serialization;

namespace WeatherForecast.Models;

public partial class Location
{
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
