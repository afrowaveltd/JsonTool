using System.Text.Json.Serialization;

namespace JsonTool.Models
{
    public sealed class Country2
    {
        [JsonPropertyName("borders")]
        public List<string>? Borders { get; set; }

        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("flags")]
        public CountryFlags? Flags { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}