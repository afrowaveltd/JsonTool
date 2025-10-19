using System.Text.Json.Serialization;
namespace JsonTool.Models
{
    public sealed class IddInfo
    {
        [JsonPropertyName("root")] 
        public string? Root { get; set; }
        [JsonPropertyName("suffixes")] 
        public List<string>? Suffixes { get; set; }
    }
}