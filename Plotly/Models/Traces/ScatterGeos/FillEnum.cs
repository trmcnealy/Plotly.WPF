using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ScatterGeos
{
    /// <summary>
    ///     Sets the area to fill with a solid color. Use with <c>fillcolor</c> if not
    ///     <c>none</c>. <c>toself</c> connects the endpoints of the trace (or each
    ///     segment of the trace if it has gaps) into a closed shape.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum FillEnum
    {
        [EnumMember(Value = @"none")]
        None = 0,

        [EnumMember(Value = @"toself")]
        ToSelf
    }
}
