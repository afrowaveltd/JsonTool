using System.Text.Json.Serialization;

namespace JsonTool.Models
{
    public sealed class CurrencyInfo
    {
        [JsonPropertyName("name")] 
        public string? Name { get; set; }
        [JsonPropertyName("symbol")] 
        public string? Symbol { get; set; }
    }
}