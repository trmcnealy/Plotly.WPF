using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Legends
{
    /// <summary>
    ///     Determines the order at which the legend items are displayed. If <c>normal</c>,
    ///     the items are displayed top-to-bottom in the same order as the input data.
    ///     If <c>reversed</c>, the items are displayed in the opposite order as <c>normal</c>.
    ///     If <c>grouped</c>, the items are displayed in groups (when a trace <c>legendgroup</c>
    ///     is provided). if <c>grouped+reversed</c>, the items are displayed in the
    ///     opposite order as <c>grouped</c>.
    /// </summary>
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum TraceOrderFlag
    {
        [EnumMember(Value = @"normal")]
        Normal = 0,

        [EnumMember(Value = @"reversed")]
        Reversed = 1,

        [EnumMember(Value = @"grouped")]
        Grouped = 2
    }
}
