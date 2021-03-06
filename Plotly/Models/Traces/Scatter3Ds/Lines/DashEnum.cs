using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Scatter3Ds.Lines
{
    /// <summary>
    ///     Sets the dash style of the lines.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DashEnum
    {
        [EnumMember(Value = @"solid")]
        Solid = 0,

        [EnumMember(Value = @"dot")]
        Dot,

        [EnumMember(Value = @"dash")]
        Dash,

        [EnumMember(Value = @"longdash")]
        LongDash,

        [EnumMember(Value = @"dashdot")]
        DashDot,

        [EnumMember(Value = @"longdashdot")]
        LongDashDot
    }
}
