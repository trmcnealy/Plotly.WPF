using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.ScatterPolarGls.Lines
{
    /// <summary>
    ///     Sets the style of the lines.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum DashEnum
    {
        [EnumMember(Value=@"solid")]
        Solid = 0,
        [EnumMember(Value=@"dot")]
        Dot,
        [EnumMember(Value=@"dash")]
        Dash,
        [EnumMember(Value=@"longdash")]
        LongDash,
        [EnumMember(Value=@"dashdot")]
        DashDot,
        [EnumMember(Value=@"longdashdot")]
        LongDashDot
    }
}