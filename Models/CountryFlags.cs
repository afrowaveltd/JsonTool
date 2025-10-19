using System.Text.Json.Serialization;

namespace JsonTool.Models
{
    public sealed class CountryFlags
    {
        [JsonPropertyName("png")]
        public string? Png { get; set; }

        [JsonPropertyName("svg")]
        public string? Svg { get; set; }

        [JsonPropertyName("alt")]
        public string? Alt { get; set; }
    }
}