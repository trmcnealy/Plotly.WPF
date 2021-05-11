using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Funnels
{
    /// <summary>
    ///     Determines if texts are kept at center or start/end points in <c>textposition</c>
    ///     <c>inside</c> mode.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum InsideTextAnchorEnum
    {
        [EnumMember(Value = @"middle")]
        Middle = 0,

        [EnumMember(Value = @"end")]
        End,

        [EnumMember(Value = @"start")]
        Start
    }
}
