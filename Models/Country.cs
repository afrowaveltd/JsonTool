using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace JsonTool.Models
{
    public sealed class Country
    {
        [JsonPropertyName("name")]
        public LocalizedName? Name { get; set; }

        [JsonPropertyName("dial_code")]
        public string? DialCode { get; set; }
        [JsonPropertyName("emoji")]
        public string? Emoji { get; set; }
        [JsonPropertyName("code")]
        public string? Code { get; set; }
    }
}