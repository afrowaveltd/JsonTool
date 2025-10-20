using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace JsonTool.Models;

/// <summary>
/// Flag resources grouped for unified model (png/svg/alt text).
/// </summary>
public sealed class FlagsInfo
{
	/// <summary>
	/// Gets or sets the URL of the PNG image representing the flag.
	/// </summary>
	[JsonPropertyName("png")] public string? Png { get; set; } // např. https://flagcdn.com/w320/cz.png

	/// <summary>
	/// Gets or sets the URL of the SVG image representing the flag.
	/// </summary>
	[JsonPropertyName("svg")] public string? Svg { get; set; } // např. https://flagcdn.com/cz.svg

	/// <summary>
	/// Gets or sets the alternative text description for the flag, if available.
	/// </summary>
	[JsonPropertyName("alt")] public string? Alt { get; set; } // popis vlajky, je-li k dispozici

	/// <summary>
	/// Gets or sets the Base64-encoded representation of the content.
	/// </summary>
	[JsonPropertyName("base64")] public string? Base64 { get; set; }

	/// <summary>
	/// Original emoji flag string used in some feeds.
	/// </summary>
	[JsonPropertyName("flag")] public string? Emoji { get; set; } // původní emoji string v některých feedech
}