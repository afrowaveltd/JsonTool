using System.Text.Json.Serialization;

namespace JsonTool.Models
{
    public sealed class LocalizedName
    {
        [JsonPropertyName("official")] 
        public string? Official { get; set; }
        [JsonPropertyName("common")] 
        public string? Common { get; set; }
    }
}