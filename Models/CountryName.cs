using System.Text.Json.Serialization;

namespace JsonTool.Models
{
    public sealed class CountryName
    {
        [JsonPropertyName("common")] 
        public string? Common { get; set; }
        [JsonPropertyName("official")] 
        public string? Official { get; set; }

        // v různých feedech bývá "native", "nativeName", apod.; sloučíme do tohoto
        [JsonPropertyName("native")] 
        public Dictionary<string, LocalizedName>? Native { get; set; }
    }
}
