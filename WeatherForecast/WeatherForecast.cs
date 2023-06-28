using System.Text.Json.Serialization;

namespace WeatherForecast
{
    public class WeatherForecast
    {
        [JsonPropertyName("fact")]
        public string? Fact { get; set; }
        [JsonPropertyName("length")]
        public int Length { get; set; }
    }
}