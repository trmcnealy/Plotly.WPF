using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.YAxes
{
    /// <summary>
    ///     Determines whether a x (y) axis is positioned at the <c>bottom</c> (<c>left</c>)
    ///     or <c>top</c> (<c>right</c>) of the plotting area.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SideEnum
    {
        [EnumMember(Value = @"top")]
        Top,

        [EnumMember(Value = @"bottom")]
        Bottom,

        [EnumMember(Value = @"left")]
        Left,

        [EnumMember(Value = @"right")]
        Right
    }
}
