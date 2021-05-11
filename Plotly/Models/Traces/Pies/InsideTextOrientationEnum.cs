using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Pies
{
    /// <summary>
    ///     Controls the orientation of the text inside chart sectors. When set to <c>auto</c>,
    ///     text may be oriented in any direction in order to be as big as possible
    ///     in the middle of a sector. The <c>horizontal</c> option orients text to
    ///     be parallel with the bottom of the chart, and may make text smaller in order
    ///     to achieve that goal. The <c>radial</c> option orients text along the radius
    ///     of the sector. The <c>tangential</c> option orients text perpendicular to
    ///     the radius of the sector.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum InsideTextOrientationEnum
    {
        [EnumMember(Value = @"auto")]
        Auto = 0,

        [EnumMember(Value = @"horizontal")]
        Horizontal,

        [EnumMember(Value = @"radial")]
        Radial,

        [EnumMember(Value = @"tangential")]
        Tangential
    }
}
