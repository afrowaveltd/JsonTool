using System.Text.Json.Serialization;

namespace JsonTool.Models
{
    /// <summary>
    /// Country flag asset references (PNG, SVG) with optional alt text.
    /// </summary>
    public sealed class CountryFlags
    {
        /// <summary>
        /// PNG flag URL.
        /// </summary>
        [JsonPropertyName("png")]
        public string? Png { get; set; }

        /// <summary>
        /// SVG flag URL.
        /// </summary>
        [JsonPropertyName("svg")]
        public string? Svg { get; set; }

        /// <summary>
        /// Alternative text describing the flag.
        /// </summary>
        [JsonPropertyName("alt")]
        public string? Alt { get; set; }
    }
}