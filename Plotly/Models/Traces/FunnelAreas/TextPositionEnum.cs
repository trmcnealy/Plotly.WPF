using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.FunnelAreas
{
    /// <summary>
    ///     Specifies the location of the <c>textinfo</c>.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TextPositionEnum
    {
        [EnumMember(Value = @"inside")]
        Inside = 0,

        [EnumMember(Value = @"none")]
        None
    }
}
