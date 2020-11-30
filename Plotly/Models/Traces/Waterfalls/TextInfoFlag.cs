using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Waterfalls
{
    /// <summary>
    ///     Determines which trace information appear on the graph. In the case of having
    ///     multiple waterfalls, totals are computed separately (per trace).
    /// </summary>
    
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum TextInfoFlag
    {
        [EnumMember(Value=@"none")]
        None = 0,
        [EnumMember(Value=@"label")]
        Label = 1,
        [EnumMember(Value=@"text")]
        Text = 2,
        [EnumMember(Value=@"initial")]
        Initial = 4,
        [EnumMember(Value=@"delta")]
        Delta = 8,
        [EnumMember(Value=@"final")]
        Final = 16
    }
}