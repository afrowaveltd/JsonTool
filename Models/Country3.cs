using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;

namespace JsonTool.Models
{
    public sealed class Country3
    {
        [JsonPropertyName("name")] 
        public CountryName? Name { get; set; }
        [JsonPropertyName("tld")] 
        public List<string>? Tld { get; set; }
        [JsonPropertyName("cca2")]
         public string? Cca2 { get; set; }
        [JsonPropertyName("ccn3")]
         public string? Ccn3 { get; set; }
        [JsonPropertyName("cca3")]
        public string? Cca3 { get; set; }
        [JsonPropertyName("cioc")] 
        public string? Cioc { get; set; }
        [JsonPropertyName("independent")] 
        public bool? Independent { get; set; }
        [JsonPropertyName("status")] 
        public string? Status { get; set; }
        [JsonPropertyName("unMember")] 
        public bool? UnMember { get; set; }

        [JsonPropertyName("currencies")] public Dictionary<string, CurrencyInfo>? Currencies { get; set; }
        [JsonPropertyName("idd")] 
        public IddInfo? Idd { get; set; }
        [JsonPropertyName("capital")] 
        public List<string>? Capital { get; set; }
        [JsonPropertyName("altSpellings")] 
        public List<string>? AltSpellings { get; set; }
        [JsonPropertyName("region")] 
        public string? Region { get; set; }
        [JsonPropertyName("subregion")] 
        public string? Subregion { get; set; }
        [JsonPropertyName("languages")] 
        public Dictionary<string, string>? Languages { get; set; }
        [JsonPropertyName("translations")] 
        public Dictionary<string, LocalizedName>? Translations { get; set; }

        [JsonPropertyName("latlng")]
         public List<double>? LatLng { get; set; }
        [JsonPropertyName("landlocked")]
         public bool? Landlocked { get; set; }
        [JsonPropertyName("borders")]
         public List<string>? Borders { get; set; }
        [JsonPropertyName("area")]
         public double? Area { get; set; }
        [JsonPropertyName("flag")]
         public string? Flag { get; set; }

        [JsonPropertyName("demonyms")]
         public Dictionary<string, GenderedDemonym>? Demonyms { get; set; }
        [JsonPropertyName("callingCodes")] 
        public List<string>? CallingCodes { get; set; }

        [JsonExtensionData] 
        public Dictionary<string, JsonElement>? Extra { get; set; }
    }
}