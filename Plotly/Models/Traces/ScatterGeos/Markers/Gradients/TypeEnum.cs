using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ScatterGeos.Markers.Gradients
{
    /// <summary>
    ///     Sets the type of gradient used to fill the markers
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value = @"none")]
        None = 0,

        [EnumMember(Value = @"radial")]
        Radial,

        [EnumMember(Value = @"horizontal")]
        Horizontal,

        [EnumMember(Value = @"vertical")]
        Vertical
    }
}
