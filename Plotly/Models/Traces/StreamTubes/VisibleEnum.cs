using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.StreamTubes
{
    /// <summary>
    ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
    ///     trace is not drawn, but can appear as a legend item (provided that the legend
    ///     itself is visible).
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum VisibleEnum
    {
        [EnumMember(Value = @"true")]
        True = 0,

        [EnumMember(Value = @"False")]
        False,

        [EnumMember(Value = @"legendonly")]
        LegendOnly
    }
}
