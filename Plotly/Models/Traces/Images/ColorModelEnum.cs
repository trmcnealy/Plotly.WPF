using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Images
{
    /// <summary>
    ///     Color model used to map the numerical color components described in <c>z</c>
    ///     into colors.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ColorModelEnum
    {
        [EnumMember(Value = @"rgb")]
        Rgb = 0,

        [EnumMember(Value = @"rgba")]
        Rgba,

        [EnumMember(Value = @"hsl")]
        Hsl,

        [EnumMember(Value = @"hsla")]
        Hsla
    }
}
