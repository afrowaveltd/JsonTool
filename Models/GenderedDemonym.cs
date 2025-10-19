using System.Text.Json.Serialization;

namespace JsonTool.Models
{
    public sealed class GenderedDemonym
    {
        [JsonPropertyName("m")] 
        public string? Male { get; set; }
        [JsonPropertyName("f")] 
        public string? Female { get; set; }
    }
}
