using System.Text.Json.Serialization;
namespace JsonTool.Models
{
    /// <summary>
    /// International direct dialing (IDD) information.
    /// </summary>
    public sealed class IddInfo
    {
        /// <summary>
        /// Root dialing prefix, e.g., "+".
        /// </summary>
        [JsonPropertyName("root")] 
        public string? Root { get; set; }
        /// <summary>
        /// List of dialing suffixes for the country/region.
        /// </summary>
        [JsonPropertyName("suffixes")] 
        public List<string>? Suffixes { get; set; }
    }
}