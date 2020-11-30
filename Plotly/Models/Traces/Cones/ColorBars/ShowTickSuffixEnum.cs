using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Cones.ColorBars
{
    /// <summary>
    ///     Same as <c>showtickprefix</c> but for tick suffixes.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum ShowTickSuffixEnum
    {
        [EnumMember(Value=@"all")]
        All = 0,
        [EnumMember(Value=@"first")]
        First,
        [EnumMember(Value=@"last")]
        Last,
        [EnumMember(Value=@"none")]
        None
    }
}