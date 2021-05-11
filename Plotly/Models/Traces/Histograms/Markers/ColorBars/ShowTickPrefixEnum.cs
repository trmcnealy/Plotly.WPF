using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Histograms.Markers.ColorBars
{
    /// <summary>
    ///     If <c>all</c>, all tick labels are displayed with a prefix. If <c>first</c>,
    ///     only the first tick is displayed with a prefix. If <c>last</c>, only the
    ///     last tick is displayed with a suffix. If <c>none</c>, tick prefixes are
    ///     hidden.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ShowTickPrefixEnum
    {
        [EnumMember(Value = @"all")]
        All = 0,

        [EnumMember(Value = @"first")]
        First,

        [EnumMember(Value = @"last")]
        Last,

        [EnumMember(Value = @"none")]
        None
    }
}
