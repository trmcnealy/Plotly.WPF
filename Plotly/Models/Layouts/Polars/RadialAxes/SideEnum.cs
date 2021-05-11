using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Polars.RadialAxes
{
    /// <summary>
    ///     Determines on which side of radial axis line the tick and tick labels appear.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SideEnum
    {
        [EnumMember(Value = @"clockwise")]
        Clockwise = 0,

        [EnumMember(Value = @"counterclockwise")]
        Counterclockwise
    }
}
