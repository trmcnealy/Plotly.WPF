using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Pies
{
    /// <summary>
    ///     Determines which trace information appear on the graph.
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

        [EnumMember(Value = @"value")]
        Value = 4,

        [EnumMember(Value = @"percent")]
        Percent = 8
    }
}
