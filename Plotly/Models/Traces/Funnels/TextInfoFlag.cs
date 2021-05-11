using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Funnels
{
    /// <summary>
    ///     Determines which trace information appear on the graph. In the case of having
    ///     multiple funnels, percentages &amp; totals are computed separately (per
    ///     trace).
    /// </summary>
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum TextInfoFlag
    {
        [EnumMember(Value = @"none")]
        None = 0,

        [EnumMember(Value = @"label")]
        Label = 1,

        [EnumMember(Value = @"text")]
        Text = 2,

        [EnumMember(Value = @"percent initial")]
        PercentInitial = 4,

        [EnumMember(Value = @"percent previous")]
        PercentPrevious = 8,

        [EnumMember(Value = @"percent total")]
        PercentTotal = 16,

        [EnumMember(Value = @"value")]
        Value = 32
    }
}
